using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CloneCustomCSharpAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CloneCustomCSharpAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CloneCustomCSharpAssetResponse)this.results[0];
			}
		}

		public CloneCustomCSharpAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}