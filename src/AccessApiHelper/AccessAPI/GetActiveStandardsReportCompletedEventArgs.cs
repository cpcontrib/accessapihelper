using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetActiveStandardsReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetActiveStandardsReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetActiveStandardsReportResponse)this.results[0];
			}
		}

		public GetActiveStandardsReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}