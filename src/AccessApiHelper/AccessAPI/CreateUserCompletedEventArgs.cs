using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateUserCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateUserResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateUserResponse)this.results[0];
			}
		}

		public CreateUserCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}