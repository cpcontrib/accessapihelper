using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class PrepareDownloadAuditCSVReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PrepareDownloadAuditCSVResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PrepareDownloadAuditCSVResponse)this.results[0];
			}
		}

		public PrepareDownloadAuditCSVReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}