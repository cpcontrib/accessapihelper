using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CancelUploadCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CancelUploadResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CancelUploadResponse)this.results[0];
			}
		}

		public CancelUploadCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}