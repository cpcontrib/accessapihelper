using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class UpdateServerMetaConfigCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public UpdateServerMetaConfigResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (UpdateServerMetaConfigResponse)this.results[0];
			}
		}

		public UpdateServerMetaConfigCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}