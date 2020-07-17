using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDebugMessagesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetDebugMessagesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetDebugMessagesResponse)this.results[0];
			}
		}

		public GetDebugMessagesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}