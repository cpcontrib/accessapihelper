using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetUserDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetUserDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetUserDataResponse)this.results[0];
			}
		}

		public GetUserDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}