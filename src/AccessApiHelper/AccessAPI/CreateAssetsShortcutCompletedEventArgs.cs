using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateAssetsShortcutCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateAssetsShortcutResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateAssetsShortcutResponse)this.results[0];
			}
		}

		public CreateAssetsShortcutCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}