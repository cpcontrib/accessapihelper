using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class PublishRefreshCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PublishRefreshResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PublishRefreshResponse)this.results[0];
			}
		}

		public PublishRefreshCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}