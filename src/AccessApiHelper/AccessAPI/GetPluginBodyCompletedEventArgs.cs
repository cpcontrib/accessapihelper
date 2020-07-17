using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPluginBodyCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPluginBodyResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPluginBodyResponse)this.results[0];
			}
		}

		public GetPluginBodyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}