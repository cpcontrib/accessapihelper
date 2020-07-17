using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetSnippetVariantTestsDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetSnippetVariantTestsDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetSnippetVariantTestsDataResponse)this.results[0];
			}
		}

		public WCOGetSnippetVariantTestsDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}