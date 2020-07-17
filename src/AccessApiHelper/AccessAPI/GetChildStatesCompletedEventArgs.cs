using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetChildStatesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetChildStatesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetChildStatesResponse)this.results[0];
			}
		}

		public GetChildStatesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}