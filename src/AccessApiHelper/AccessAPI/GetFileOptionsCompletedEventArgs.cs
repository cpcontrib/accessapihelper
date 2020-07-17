using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetFileOptionsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetFileOptionsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetFileOptionsResponse)this.results[0];
			}
		}

		public GetFileOptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}