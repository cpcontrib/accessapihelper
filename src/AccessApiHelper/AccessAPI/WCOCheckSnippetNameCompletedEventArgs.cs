using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOCheckSnippetNameCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateBranchResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateBranchResponse)this.results[0];
			}
		}

		public WCOCheckSnippetNameCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}