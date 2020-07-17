using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetProviderInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetProviderInfoResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetProviderInfoResponse)this.results[0];
			}
		}

		public GetProviderInfoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}