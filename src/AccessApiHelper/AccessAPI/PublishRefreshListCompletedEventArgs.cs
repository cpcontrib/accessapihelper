using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class PublishRefreshListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PublishRefreshListResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PublishRefreshListResponse)this.results[0];
			}
		}

		public PublishRefreshListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}