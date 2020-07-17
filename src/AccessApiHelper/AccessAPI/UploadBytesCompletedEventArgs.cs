using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class UploadBytesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public UploadResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (UploadResponse)this.results[0];
			}
		}

		public UploadBytesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}