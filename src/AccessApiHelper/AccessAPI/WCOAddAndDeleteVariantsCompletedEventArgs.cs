using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOAddAndDeleteVariantsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOAddAndDeleteVariantsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOAddAndDeleteVariantsResponse)this.results[0];
			}
		}

		public WCOAddAndDeleteVariantsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}