using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetFtpServersDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetFtpServersDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetFtpServersDataResponse)this.results[0];
			}
		}

		public GetFtpServersDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}