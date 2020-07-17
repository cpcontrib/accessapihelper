using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGoogleAnalyticsPropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetGoogleAnalyticsPropertiesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetGoogleAnalyticsPropertiesResponse)this.results[0];
			}
		}

		public GetGoogleAnalyticsPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}