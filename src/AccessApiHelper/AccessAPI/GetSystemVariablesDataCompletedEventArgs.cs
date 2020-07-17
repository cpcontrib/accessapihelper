using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetSystemVariablesDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetSystemVariablesDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetSystemVariablesDataResponse)this.results[0];
			}
		}

		public GetSystemVariablesDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}