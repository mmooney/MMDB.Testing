using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Dynamic;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MMDB.Testing.WebsiteBeaterUpper
{
	public partial class MainForm : Form
	{
		private List<ThreadData> _threadDataList;
		private List<Thread> _threadList;
		private System.Windows.Forms.Timer _timer;
		private volatile bool _stopRequested;

		public MainForm()
		{
			InitializeComponent();
			_grdData.AutoGenerateColumns = false;
		}

		private void _btnGo_Click(object sender, EventArgs e)
		{
			_stopRequested = false;
			_threadDataList = new List<ThreadData>();
			_threadList = new List<Thread>();
			_timer = new System.Windows.Forms.Timer();
			_timer.Interval = 1000;
			_timer.Tick += 
				(x,y) => 
				{
					_grdData.Refresh();
					CheckIfDone();
				};
			_timer.Start();
			for(int i = 0; i < _numThreadCount.Value; i++)
			{
				dynamic inputData = new ExpandoObject();
				inputData.RequestedRunCount = Convert.ToInt32(_numRunsPerThreadCount.Value);
				inputData.Url = _cboUrl.Text;
				ParameterizedThreadStart start = new ParameterizedThreadStart(this.ThreadProc);
				Thread thread = new Thread(start);
				thread.Start(inputData);
				ThreadData threadData = new ThreadData
				{
					ThreadId = thread.ManagedThreadId,
					ThreadNumber = i,
					RequestedRunCount = inputData.RequestedRunCount
				};
				_threadDataList.Add(threadData);
				_threadList.Add(thread);
			}
			_btnGo.Enabled = false;
			_btnCancel.Enabled = true;
			_grdData.DataSource = this._threadDataList;
			this.AddMRU(_cboUrl.Text);
		}

		private void _btnCancel_Click(object sender, EventArgs e)
		{
			_stopRequested = true;
		}


		private void ThreadProc(dynamic inputData)
		{
			DateTime startTime = DateTime.Now;
			int requestedRunCount = inputData.RequestedRunCount;
			string url = inputData.Url;
			for(int i = 0; i < requestedRunCount; i++)
			{
				if(_stopRequested)
				{
					this.RaiseCancel(Thread.CurrentThread.ManagedThreadId);
					break;
				}
				try 
				{
					var request = (HttpWebRequest)HttpWebRequest.Create(url);
					using(var response = request.GetResponse())
					{
						using(var responseStream = response.GetResponseStream())
						{
							using(var reader = new StreamReader(responseStream))
							{
								string responseData = reader.ReadToEnd();
								this.RaiseSuccess(Thread.CurrentThread.ManagedThreadId, startTime, DateTime.Now, responseData);
							}
						} 
					}
				}
				catch(Exception err)
				{
					this.RaiseError(Thread.CurrentThread.ManagedThreadId, startTime, DateTime.Now, err);
				}
			}
		}

		private delegate void RaiseCancelDelegate(int threadId);

		private void RaiseCancel(int threadId)
		{
			if(this.InvokeRequired) 
			{
				var func = new RaiseCancelDelegate(this.RaiseCancel);
				this.Invoke(func, threadId);
			}
			else 
			{
				var threadData = this._threadDataList.SingleOrDefault(i => i.ThreadId == threadId);
				if (threadData == null)
				{
					throw new Exception("Could not find thread data for thread ID " + threadId.ToString());
				}
				threadData.Cancelled = true;
			}
		}

		private delegate void RaiseSuccessDelegate(int threadId, DateTime startTime, DateTime endTime, string responseData);

		private void RaiseSuccess(int threadId, DateTime startTime, DateTime endTime, string responseData)
		{
			if(this.InvokeRequired)
			{
				var func = new RaiseSuccessDelegate(this.RaiseSuccess);
				this.Invoke(func, threadId, startTime, endTime, responseData);
			}	
			else 
			{
				var threadData = this._threadDataList.SingleOrDefault(i => i.ThreadId == threadId);
				if (threadData == null)
				{
					throw new Exception("Could not find thread data for thread ID " + threadId.ToString());
				}
				var runData = new ThreadRunData
				{
					Success = true,
					StartTime = startTime,
					EndTime = endTime,
					RunData = responseData,
					Exception = null
				};
				threadData.ThreadRunData.Add(runData);
			}
		}

		private void CheckIfDone()
		{
			var notDone = _threadDataList.Where(i=>i.RemainingCount > 0);
			if(!_threadDataList.Any(i=>i.RemainingCount > 0 && !i.Cancelled))
			{
				_btnCancel.Enabled = false;
				_btnGo.Enabled = true;
				using (_timer)
				{
					_timer = null;
				}
			}
		}

		private delegate void RaiseErrorDelegate(int threadId, DateTime startTime, DateTime endTime, Exception err);

		private void RaiseError(int threadId, DateTime startTime, DateTime endTime, Exception err)
		{
			if(this.InvokeRequired)
			{
				var func = new RaiseErrorDelegate(this.RaiseError);
				this.Invoke(func, threadId, startTime, endTime, err);
			}
			else 
			{
				var threadData = this._threadDataList.SingleOrDefault(i=>i.ThreadId == threadId);
				if(threadData == null)
				{
					throw new Exception("Could not find thread data for thread ID " + threadId.ToString());
				}
				var runData = new ThreadRunData
				{
					Success = false,
					StartTime = startTime,
					EndTime = endTime,
					RunData = err.ToString(),
					Exception = err
				};
				threadData.ThreadRunData.Add(runData);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.LoadMRU();
			_btnGo.Enabled = true;
			_btnCancel.Enabled = false;
		}

		private void LoadMRU()
		{
			string fileName = Path.Combine(Application.UserAppDataPath, Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".json");
			try 
			{
				if(File.Exists(fileName))
				{
					using(var reader = new StreamReader(fileName))
					{
						using(var jsonReader = new JsonTextReader(reader))
						{
							JsonSerializer serializer = new JsonSerializer();
							var parsedData = serializer.Deserialize<List<string>>(jsonReader);
							_cboUrl.Items.Clear();
							_cboUrl.Items.AddRange(parsedData.ToArray());
						}
					}
				}
			}
			catch(Exception err)
			{
				MessageBox.Show("Unable to read recently used list from " + fileName + Environment.NewLine + err.ToString());
			}
		}

		private void AddMRU(string url)
		{
			string fileName = Path.Combine(Application.UserAppDataPath, Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".json");
			try
			{
				List<string> data = new List<string>();
				if (File.Exists(fileName))
				{
					using (var reader = new StreamReader(fileName))
					{
						using (var jsonReader = new JsonTextReader(reader))
						{
							JsonSerializer serializer = new JsonSerializer();
							data = serializer.Deserialize<List<string>>(jsonReader);
						}
					}
				}
				while(data.Contains(url, StringComparer.CurrentCultureIgnoreCase))
				{
					data.Remove(data.First(i=>i.Equals(url, StringComparison.CurrentCultureIgnoreCase)));
				}
				data.Insert(0, url);
				using(var writer = new StreamWriter(fileName,  false))
				{
					var serializer = new JsonSerializer();
					serializer.Serialize(writer, data);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show("Unable to read recently used list from " + fileName + Environment.NewLine + err.ToString());
			}
		}
	}
}
