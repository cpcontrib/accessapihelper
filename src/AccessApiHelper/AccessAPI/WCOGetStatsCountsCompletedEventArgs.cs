using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetStatsCountsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetStatsCountsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetStatsCountsResponse)this.results[0];
			}
		}

		public WCOGetStatsCountsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}