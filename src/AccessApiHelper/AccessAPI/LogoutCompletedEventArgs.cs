using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class LogoutCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public LogoutResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (LogoutResponse)this.results[0];
			}
		}

		public LogoutCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}