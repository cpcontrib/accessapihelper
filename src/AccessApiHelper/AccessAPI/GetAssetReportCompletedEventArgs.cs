using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public AssetReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (AssetReportResponse)this.results[0];
			}
		}

		public GetAssetReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}