using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPasswordPolicyCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPasswordPolicyResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPasswordPolicyResponse)this.results[0];
			}
		}

		public GetPasswordPolicyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}