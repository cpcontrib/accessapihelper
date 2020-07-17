using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateDashboardCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateDashboardResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateDashboardResponse)this.results[0];
			}
		}

		public CreateDashboardCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}