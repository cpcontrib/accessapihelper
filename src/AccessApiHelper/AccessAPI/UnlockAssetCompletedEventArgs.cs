using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class UnlockAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public UnlockAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (UnlockAssetResponse)this.results[0];
			}
		}

		public UnlockAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}