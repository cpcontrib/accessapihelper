using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOSaveSelectionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOSaveSelectionResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOSaveSelectionResponse)this.results[0];
			}
		}

		public WCOSaveSelectionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}