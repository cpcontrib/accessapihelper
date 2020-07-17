using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetProvidersCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetProvidersResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetProvidersResponse)this.results[0];
			}
		}

		public GetProvidersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}