using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPerformanceDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPerformanceDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPerformanceDataResponse)this.results[0];
			}
		}

		public GetPerformanceDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}