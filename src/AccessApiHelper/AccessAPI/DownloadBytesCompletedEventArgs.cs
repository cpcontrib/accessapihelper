using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class DownloadBytesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DownloadResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DownloadResponse)this.results[0];
			}
		}

		public DownloadBytesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}