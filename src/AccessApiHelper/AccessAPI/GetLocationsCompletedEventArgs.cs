using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetLocationsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetLocationsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetLocationsResponse)this.results[0];
			}
		}

		public GetLocationsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}