using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetPublishingServerMetaDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetPublishingServerMetaDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetPublishingServerMetaDataResponse)this.results[0];
			}
		}

		public SetPublishingServerMetaDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}