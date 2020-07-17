using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class DeleteEmailSenderCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DeleteEmailSenderResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DeleteEmailSenderResponse)this.results[0];
			}
		}

		public DeleteEmailSenderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}