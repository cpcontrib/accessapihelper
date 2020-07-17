using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPublishingActivity2CompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPublishingActivity2Response Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPublishingActivity2Response)this.results[0];
			}
		}

		public GetPublishingActivity2CompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}