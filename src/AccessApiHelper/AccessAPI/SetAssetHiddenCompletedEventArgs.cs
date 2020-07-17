using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAssetHiddenCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAssetHiddenResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAssetHiddenResponse)this.results[0];
			}
		}

		public SetAssetHiddenCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}