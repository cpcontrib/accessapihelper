using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetPasswordCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetPasswordResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetPasswordResponse)this.results[0];
			}
		}

		public SetPasswordCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}