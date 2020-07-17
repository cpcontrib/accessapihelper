using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetVariantCountsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetVariantCountsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetVariantCountsResponse)this.results[0];
			}
		}

		public WCOGetVariantCountsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}