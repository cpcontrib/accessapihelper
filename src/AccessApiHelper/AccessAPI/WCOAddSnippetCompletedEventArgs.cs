using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOAddSnippetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOAddSnippetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOAddSnippetResponse)this.results[0];
			}
		}

		public WCOAddSnippetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}