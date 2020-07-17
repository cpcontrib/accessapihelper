using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetFacebookInsightsDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetFacebookInsightsDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetFacebookInsightsDataResponse)this.results[0];
			}
		}

		public GetFacebookInsightsDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}