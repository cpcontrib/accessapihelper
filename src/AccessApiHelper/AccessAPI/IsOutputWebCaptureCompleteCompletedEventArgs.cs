using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class IsOutputWebCaptureCompleteCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public IsOutputWebCaptureCompleteResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (IsOutputWebCaptureCompleteResponse)this.results[0];
			}
		}

		public IsOutputWebCaptureCompleteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}