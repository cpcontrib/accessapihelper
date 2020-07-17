using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAssetFlaggedCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAssetFlaggedResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAssetFlaggedResponse)this.results[0];
			}
		}

		public SetAssetFlaggedCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}