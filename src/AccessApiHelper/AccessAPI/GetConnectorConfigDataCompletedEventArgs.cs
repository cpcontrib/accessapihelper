using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetConnectorConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetConnectorConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetConnectorConfigDataResponse)this.results[0];
			}
		}

		public GetConnectorConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}