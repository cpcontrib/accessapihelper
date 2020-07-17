using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetJobActivityCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetJobActivityResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetJobActivityResponse)this.results[0];
			}
		}

		public GetJobActivityCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}