using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGoogleAnalyticsAccountsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetGoogleAnalyticsAccountsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetGoogleAnalyticsAccountsResponse)this.results[0];
			}
		}

		public GetGoogleAnalyticsAccountsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}