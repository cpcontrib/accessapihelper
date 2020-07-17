using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAlertConfigCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAlertConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAlertConfigDataResponse)this.results[0];
			}
		}

		public SetAlertConfigCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}