using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOCreateConversionUrlCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOCreateConversionUrlResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOCreateConversionUrlResponse)this.results[0];
			}
		}

		public WCOCreateConversionUrlCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}