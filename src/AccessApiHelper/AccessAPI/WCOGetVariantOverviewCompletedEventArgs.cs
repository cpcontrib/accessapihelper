using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetVariantOverviewCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetVariantOverviewResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetVariantOverviewResponse)this.results[0];
			}
		}

		public WCOGetVariantOverviewCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}