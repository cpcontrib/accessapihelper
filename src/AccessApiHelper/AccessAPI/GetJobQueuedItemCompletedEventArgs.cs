using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetJobQueuedItemCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetJobQueueItemResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetJobQueueItemResponse)this.results[0];
			}
		}

		public GetJobQueuedItemCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}