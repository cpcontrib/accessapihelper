using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetOrphanReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetOrphanReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetOrphanReportResponse)this.results[0];
			}
		}

		public GetOrphanReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}