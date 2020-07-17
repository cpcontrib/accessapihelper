using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class DeleteConnectorCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DeleteConnectorResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DeleteConnectorResponse)this.results[0];
			}
		}

		public DeleteConnectorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}