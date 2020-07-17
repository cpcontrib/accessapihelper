using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetOdbcServersDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetOdbcServersDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetOdbcServersDataResponse)this.results[0];
			}
		}

		public GetOdbcServersDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}