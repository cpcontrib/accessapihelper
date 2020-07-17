using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPublishHistoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPublishHistoryResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPublishHistoryResponse)this.results[0];
			}
		}

		public GetPublishHistoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}