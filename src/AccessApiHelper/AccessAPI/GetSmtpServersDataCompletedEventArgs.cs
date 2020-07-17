using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetSmtpServersDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetSmtpServersDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetSmtpServersDataResponse)this.results[0];
			}
		}

		public GetSmtpServersDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}