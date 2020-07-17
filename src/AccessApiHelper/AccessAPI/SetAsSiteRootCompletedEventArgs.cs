using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAsSiteRootCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAsSiteRootResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAsSiteRootResponse)this.results[0];
			}
		}

		public SetAsSiteRootCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}