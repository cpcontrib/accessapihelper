using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetPublishingServersMetaDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetPublishingServersMetaDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetPublishingServersMetaDataResponse)this.results[0];
			}
		}

		public GetPublishingServersMetaDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}