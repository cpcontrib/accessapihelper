using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class FinishDownloadAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public FinishDownloadAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (FinishDownloadAssetResponse)this.results[0];
			}
		}

		public FinishDownloadAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}