using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCODetachSnippetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCODetachSnippetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCODetachSnippetResponse)this.results[0];
			}
		}

		public WCODetachSnippetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}