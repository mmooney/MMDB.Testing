using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMDB.Testing.WebsiteBeaterUpper
{
	public class ThreadData
	{
		public int ThreadId { get; set; }
		public int ThreadNumber { get; set; }
		public int RequestedRunCount { get; set; }

		public int CompleteCount
		{
			get 
			{
				return this.ThreadRunData.Count();
			}
		}

		public int SuccessCount 
		{
			get
			{
				return this.ThreadRunData.Where(i=>i.Success).Count();
			}
		}

		public int FailedCount 
		{ 
			get
			{
				return this.ThreadRunData.Where(i=>!i.Success).Count();
			}
		}

		public int RemainingCount 
		{
			get 
			{
				return (this.RequestedRunCount - this.ThreadRunData.Count());
			}
		}

		public double? AverageResponseTimeMilliseconds
		{
			get 
			{
				if(this.ThreadRunData.Any())
				{
					return this.ThreadRunData.Average(i=>i.ResponseTimeMilliseconds);
				}
				else 
				{
					return null;
				}
			}
		}

		public List<ThreadRunData> ThreadRunData { get; set; }

		public ThreadData()
		{
			this.ThreadRunData = new List<ThreadRunData>();
		}

		public bool Cancelled { get; set; }
	}
}
