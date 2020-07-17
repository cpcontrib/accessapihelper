using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetSelectListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetSelectListResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetSelectListResponse)this.results[0];
			}
		}

		public SetSelectListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}