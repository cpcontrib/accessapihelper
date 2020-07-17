using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetCountsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetCountsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetCountsResponse)this.results[0];
			}
		}

		public WCOGetCountsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}