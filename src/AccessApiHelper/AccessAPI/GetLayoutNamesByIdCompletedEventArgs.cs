using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetLayoutNamesByIdCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetLayoutNamesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetLayoutNamesResponse)this.results[0];
			}
		}

		public GetLayoutNamesByIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}