using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAssetDeletedCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAssetDeletedResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAssetDeletedResponse)this.results[0];
			}
		}

		public SetAssetDeletedCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}