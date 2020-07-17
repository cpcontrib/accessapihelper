using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ClonePublishingPackageCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ClonePublishingPackageResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ClonePublishingPackageResponse)this.results[0];
			}
		}

		public ClonePublishingPackageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}