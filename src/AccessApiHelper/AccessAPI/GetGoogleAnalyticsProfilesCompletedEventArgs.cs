using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGoogleAnalyticsProfilesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetGoogleAnalyticsProfilesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetGoogleAnalyticsProfilesResponse)this.results[0];
			}
		}

		public GetGoogleAnalyticsProfilesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}