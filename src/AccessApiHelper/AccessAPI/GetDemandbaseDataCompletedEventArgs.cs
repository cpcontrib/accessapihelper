using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDemandbaseDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetDemandbaseDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetDemandbaseDataResponse)this.results[0];
			}
		}

		public GetDemandbaseDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}