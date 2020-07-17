using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetPasswordPolicyCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetPasswordPolicyResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetPasswordPolicyResponse)this.results[0];
			}
		}

		public SetPasswordPolicyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}