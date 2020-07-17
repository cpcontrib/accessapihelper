using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class StopTemplateDebuggingCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public StopTemplateDebuggingResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (StopTemplateDebuggingResponse)this.results[0];
			}
		}

		public StopTemplateDebuggingCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}