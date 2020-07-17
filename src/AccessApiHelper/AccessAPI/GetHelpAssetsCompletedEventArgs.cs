using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetHelpAssetsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetHelpAssetsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetHelpAssetsResponse)this.results[0];
			}
		}

		public GetHelpAssetsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}