using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetManagedFacebookAccountsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetManagedFacebookAccountsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetManagedFacebookAccountsResponse)this.results[0];
			}
		}

		public GetManagedFacebookAccountsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}