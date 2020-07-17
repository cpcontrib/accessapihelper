using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetLayoutsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetLayoutsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetLayoutsResponse)this.results[0];
			}
		}

		public GetLayoutsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}