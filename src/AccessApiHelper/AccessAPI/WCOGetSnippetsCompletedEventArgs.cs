using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetSnippetsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetSnippetsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetSnippetsResponse)this.results[0];
			}
		}

		public WCOGetSnippetsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}