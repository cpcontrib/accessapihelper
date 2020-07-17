using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetWorkflowPropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetWorkflowPropertiesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetWorkflowPropertiesResponse)this.results[0];
			}
		}

		public GetWorkflowPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}