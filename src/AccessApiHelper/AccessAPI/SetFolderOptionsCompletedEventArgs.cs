using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetFolderOptionsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetFolderOptionsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetFolderOptionsResponse)this.results[0];
			}
		}

		public SetFolderOptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}