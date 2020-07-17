using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetTwitterAuthLinkCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetTwitterAuthLinkResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetTwitterAuthLinkResponse)this.results[0];
			}
		}

		public GetTwitterAuthLinkCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}