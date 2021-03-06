using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOUpdateVariantCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOUpdateVariantResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOUpdateVariantResponse)this.results[0];
			}
		}

		public WCOUpdateVariantCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}