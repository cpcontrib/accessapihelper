using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGeneralConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetGeneralConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetGeneralConfigDataResponse)this.results[0];
			}
		}

		public GetGeneralConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}