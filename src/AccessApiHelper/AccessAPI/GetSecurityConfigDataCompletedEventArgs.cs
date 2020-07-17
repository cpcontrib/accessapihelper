using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetSecurityConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetSecurityConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetSecurityConfigDataResponse)this.results[0];
			}
		}

		public GetSecurityConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}