using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetWorkflowPropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetWorkflowPropertiesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetWorkflowPropertiesResponse)this.results[0];
			}
		}

		public SetWorkflowPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}