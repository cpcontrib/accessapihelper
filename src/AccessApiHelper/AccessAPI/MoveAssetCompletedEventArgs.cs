using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class MoveAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public MoveAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (MoveAssetResponse)this.results[0];
			}
		}

		public MoveAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}