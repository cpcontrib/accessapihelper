using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class DeleteUserCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DeleteUserResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DeleteUserResponse)this.results[0];
			}
		}

		public DeleteUserCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}