using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetCPAvatarsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetCPAvatarsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetCPAvatarsResponse)this.results[0];
			}
		}

		public GetCPAvatarsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}