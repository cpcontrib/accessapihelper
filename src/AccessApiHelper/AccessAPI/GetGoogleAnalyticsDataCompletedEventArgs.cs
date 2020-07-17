using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGoogleAnalyticsDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetGoogleAnalyticsDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetGoogleAnalyticsDataResponse)this.results[0];
			}
		}

		public GetGoogleAnalyticsDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}