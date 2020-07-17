using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CloneAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CloneAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CloneAssetResponse)this.results[0];
			}
		}

		public CloneAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}