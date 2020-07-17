using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RevertAssetVersionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public RevertAssetVersionResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (RevertAssetVersionResponse)this.results[0];
			}
		}

		public RevertAssetVersionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}