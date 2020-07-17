using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDiagnosticsReportDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetDiagnosticsReportDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetDiagnosticsReportDataResponse)this.results[0];
			}
		}

		public GetDiagnosticsReportDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}