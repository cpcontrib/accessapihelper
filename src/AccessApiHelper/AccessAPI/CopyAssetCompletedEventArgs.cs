using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CopyAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CopyAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CopyAssetResponse)this.results[0];
			}
		}

		public CopyAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}