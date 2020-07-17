using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RefreshPublishingPackageCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public RefreshPublishingPackageResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (RefreshPublishingPackageResponse)this.results[0];
			}
		}

		public RefreshPublishingPackageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}