using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetFileOptionsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetFileOptionsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetFileOptionsResponse)this.results[0];
			}
		}

		public SetFileOptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}