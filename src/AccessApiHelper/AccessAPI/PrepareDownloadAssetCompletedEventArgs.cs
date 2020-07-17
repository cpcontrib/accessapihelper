using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class PrepareDownloadAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PrepareDownloadResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PrepareDownloadResponse)this.results[0];
			}
		}

		public PrepareDownloadAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}