using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetStatusFromActiveStandardsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetStatusFromActiveStandardsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetStatusFromActiveStandardsResponse)this.results[0];
			}
		}

		public GetStatusFromActiveStandardsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}