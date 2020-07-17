using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetSmtpServerDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetSmtpServerDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetSmtpServerDataResponse)this.results[0];
			}
		}

		public SetSmtpServerDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}