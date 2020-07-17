using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class DeleteUsersCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DeleteUsersResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DeleteUsersResponse)this.results[0];
			}
		}

		public DeleteUsersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}