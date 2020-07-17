using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class AuthenticateCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public AuthenticateResponseWCF Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (AuthenticateResponseWCF)this.results[0];
			}
		}

		public AuthenticateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}