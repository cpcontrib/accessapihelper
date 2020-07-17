using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetOutputURLCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetOutputURLResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetOutputURLResponse)this.results[0];
			}
		}

		public GetOutputURLCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}