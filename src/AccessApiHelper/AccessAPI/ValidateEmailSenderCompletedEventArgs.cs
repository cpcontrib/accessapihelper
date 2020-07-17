using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ValidateEmailSenderCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ValidateEmailSenderResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ValidateEmailSenderResponse)this.results[0];
			}
		}

		public ValidateEmailSenderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}