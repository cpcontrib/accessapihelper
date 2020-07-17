using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetOrphanReportServerDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetOrphanReportServerDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetOrphanReportServerDataResponse)this.results[0];
			}
		}

		public GetOrphanReportServerDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}