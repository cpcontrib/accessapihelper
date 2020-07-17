using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetConnectorConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetConnectorConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetConnectorConfigDataResponse)this.results[0];
			}
		}

		public SetConnectorConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}