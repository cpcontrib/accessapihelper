using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPublishingActivityCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PublishingActivityListResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PublishingActivityListResponse)this.results[0];
			}
		}

		public GetPublishingActivityCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}