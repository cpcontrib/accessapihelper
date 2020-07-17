using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateFolderByModelIdCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateFolderByModelIdResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateFolderByModelIdResponse)this.results[0];
			}
		}

		public CreateFolderByModelIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}