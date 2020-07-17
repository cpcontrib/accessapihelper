using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGeneralWCOConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetGeneralWCOConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetGeneralWCOConfigDataResponse)this.results[0];
			}
		}

		public GetGeneralWCOConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}