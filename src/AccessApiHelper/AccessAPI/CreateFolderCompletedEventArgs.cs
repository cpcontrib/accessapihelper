using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateFolderCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateFolderResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateFolderResponse)this.results[0];
			}
		}

		public CreateFolderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}