using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMDB.Testing.WebsiteBeaterUpper
{
	public class ThreadRunData
	{
		public bool Success { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string RunData { get; set; }
		public Exception Exception { get; set; }

		public double ResponseTimeMilliseconds 
		{
			get 
			{
				return this.EndTime.Subtract(this.StartTime).TotalMilliseconds;
			}
		}
	}
}
