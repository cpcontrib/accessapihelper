using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetPublishingServerDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetPublishingServerDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetPublishingServerDataResponse)this.results[0];
			}
		}

		public SetPublishingServerDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}