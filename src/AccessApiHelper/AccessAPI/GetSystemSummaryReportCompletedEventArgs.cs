using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetSystemSummaryReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SystemSummaryReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SystemSummaryReportResponse)this.results[0];
			}
		}

		public GetSystemSummaryReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}