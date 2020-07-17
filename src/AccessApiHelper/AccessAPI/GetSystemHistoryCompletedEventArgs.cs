using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetSystemHistoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetSystemHistoryResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetSystemHistoryResponse)this.results[0];
			}
		}

		public GetSystemHistoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}