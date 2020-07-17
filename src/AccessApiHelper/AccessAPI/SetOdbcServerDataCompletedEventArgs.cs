using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetOdbcServerDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetOdbcServerDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetOdbcServerDataResponse)this.results[0];
			}
		}

		public SetOdbcServerDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}