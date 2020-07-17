using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetUserDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetUserDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetUserDataResponse)this.results[0];
			}
		}

		public SetUserDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}