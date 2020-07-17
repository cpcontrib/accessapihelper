using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ClearErrorsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ClearErrorsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ClearErrorsResponse)this.results[0];
			}
		}

		public ClearErrorsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}