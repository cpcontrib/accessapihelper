using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class StopPublishingSessionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public StopPublishingSessionResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (StopPublishingSessionResponse)this.results[0];
			}
		}

		public StopPublishingSessionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}