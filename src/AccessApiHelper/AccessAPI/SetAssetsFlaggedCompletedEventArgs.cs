using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAssetsFlaggedCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAssetsFlaggedResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAssetsFlaggedResponse)this.results[0];
			}
		}

		public SetAssetsFlaggedCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}