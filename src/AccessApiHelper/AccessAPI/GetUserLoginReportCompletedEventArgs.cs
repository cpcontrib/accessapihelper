using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetUserLoginReportCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public UserLoginReportResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (UserLoginReportResponse)this.results[0];
			}
		}

		public GetUserLoginReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}