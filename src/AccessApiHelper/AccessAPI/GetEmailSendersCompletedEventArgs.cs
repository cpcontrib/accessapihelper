using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetEmailSendersCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetEmailSendersResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetEmailSendersResponse)this.results[0];
			}
		}

		public GetEmailSendersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}