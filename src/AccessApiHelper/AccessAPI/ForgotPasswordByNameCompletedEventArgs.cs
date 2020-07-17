using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ForgotPasswordByNameCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ForgotPasswordResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ForgotPasswordResponse)this.results[0];
			}
		}

		public ForgotPasswordByNameCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}