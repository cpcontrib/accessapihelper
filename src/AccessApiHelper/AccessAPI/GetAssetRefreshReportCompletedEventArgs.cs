using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetRefreshReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetRefreshReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetRefreshReportResponse)this.results[0];
			}
		}

		public GetAssetRefreshReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}