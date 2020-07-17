using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class StartFindOrphanReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public StartFindOrphanReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (StartFindOrphanReportResponse)this.results[0];
			}
		}

		public StartFindOrphanReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}