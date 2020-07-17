using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAssetsHiddenCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAssetsHiddenResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAssetsHiddenResponse)this.results[0];
			}
		}

		public SetAssetsHiddenCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}