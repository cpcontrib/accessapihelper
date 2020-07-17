using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetOutputUrlCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetOutputUrlResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetOutputUrlResponse)this.results[0];
			}
		}

		public WCOGetOutputUrlCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}