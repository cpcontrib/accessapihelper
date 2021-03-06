using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetConnectorCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetConnectorResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetConnectorResponse)this.results[0];
			}
		}

		public GetConnectorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}