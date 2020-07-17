using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPublishingServersDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPublishingServersDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPublishingServersDataResponse)this.results[0];
			}
		}

		public GetPublishingServersDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}