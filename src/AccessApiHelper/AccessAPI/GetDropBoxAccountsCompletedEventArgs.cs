using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDropBoxAccountsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetDropBoxAccountsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetDropBoxAccountsResponse)this.results[0];
			}
		}

		public GetDropBoxAccountsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}