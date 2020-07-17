using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPublishingPropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PublishingPropertiesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PublishingPropertiesResponse)this.results[0];
			}
		}

		public GetPublishingPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}