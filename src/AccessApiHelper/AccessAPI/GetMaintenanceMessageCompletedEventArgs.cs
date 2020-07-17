using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetMaintenanceMessageCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetMaintenanceMessageResult Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetMaintenanceMessageResult)this.results[0];
			}
		}

		public GetMaintenanceMessageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}