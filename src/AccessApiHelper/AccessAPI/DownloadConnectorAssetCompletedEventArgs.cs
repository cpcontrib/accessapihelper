using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class DownloadConnectorAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DownloadAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DownloadAssetResponse)this.results[0];
			}
		}

		public DownloadConnectorAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}