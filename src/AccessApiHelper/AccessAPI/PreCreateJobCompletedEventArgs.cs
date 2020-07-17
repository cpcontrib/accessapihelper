using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class PreCreateJobCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PreCreateJobResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PreCreateJobResponse)this.results[0];
			}
		}

		public PreCreateJobCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}