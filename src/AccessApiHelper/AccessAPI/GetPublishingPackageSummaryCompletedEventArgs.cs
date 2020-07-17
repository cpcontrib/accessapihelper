using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPublishingPackageSummaryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPublishingPackageSummaryResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPublishingPackageSummaryResponse)this.results[0];
			}
		}

		public GetPublishingPackageSummaryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}