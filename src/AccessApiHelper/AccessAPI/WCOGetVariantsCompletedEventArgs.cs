using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetVariantsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetVariantsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetVariantsResponse)this.results[0];
			}
		}

		public WCOGetVariantsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}