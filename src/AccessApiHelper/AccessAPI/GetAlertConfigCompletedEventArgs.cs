using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAlertConfigCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAlertConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAlertConfigDataResponse)this.results[0];
			}
		}

		public GetAlertConfigCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}