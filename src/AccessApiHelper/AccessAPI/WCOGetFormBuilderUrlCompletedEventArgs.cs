using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetFormBuilderUrlCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetFormBuilderUrlResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetFormBuilderUrlResponse)this.results[0];
			}
		}

		public WCOGetFormBuilderUrlCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}