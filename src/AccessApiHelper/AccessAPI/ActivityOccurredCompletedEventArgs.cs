using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ActivityOccurredCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ResultClass Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ResultClass)this.results[0];
			}
		}

		public ActivityOccurredCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}