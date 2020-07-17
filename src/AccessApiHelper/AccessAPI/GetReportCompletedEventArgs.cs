using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ReportResponse)this.results[0];
			}
		}

		public GetReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}