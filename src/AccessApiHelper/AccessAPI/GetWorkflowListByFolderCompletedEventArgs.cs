using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetWorkflowListByFolderCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetWorkflowListByFolderResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetWorkflowListByFolderResponse)this.results[0];
			}
		}

		public GetWorkflowListByFolderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}