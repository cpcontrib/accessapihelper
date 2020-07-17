using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class PublishListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PublishListResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PublishListResponse)this.results[0];
			}
		}

		public PublishListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}