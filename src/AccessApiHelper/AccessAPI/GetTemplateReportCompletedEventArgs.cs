using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetTemplateReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public TemplateReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (TemplateReportResponse)this.results[0];
			}
		}

		public GetTemplateReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}