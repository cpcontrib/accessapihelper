using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPublishingServersCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPublishingServersResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPublishingServersResponse)this.results[0];
			}
		}

		public GetPublishingServersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}