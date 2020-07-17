using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetWorkflowsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetWorkflowsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetWorkflowsResponse)this.results[0];
			}
		}

		public GetWorkflowsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}