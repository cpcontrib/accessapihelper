using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class DownloadAssetsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DownloadAssetsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DownloadAssetsResponse)this.results[0];
			}
		}

		public DownloadAssetsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}