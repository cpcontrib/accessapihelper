using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ClearQueuedAssetsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ClearQueuedAssetsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ClearQueuedAssetsResponse)this.results[0];
			}
		}

		public ClearQueuedAssetsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}