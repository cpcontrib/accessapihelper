using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateFileCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateFileResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateFileResponse)this.results[0];
			}
		}

		public CreateFileCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}