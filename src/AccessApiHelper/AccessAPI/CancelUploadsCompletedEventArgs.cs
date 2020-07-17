using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CancelUploadsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CancelUploadsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CancelUploadsResponse)this.results[0];
			}
		}

		public CancelUploadsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}