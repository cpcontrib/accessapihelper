using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SendToActiveStandardsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SendToActiveStandardsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SendToActiveStandardsResponse)this.results[0];
			}
		}

		public SendToActiveStandardsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}