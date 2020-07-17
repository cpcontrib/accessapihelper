using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class UnBranchCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public UnBranchResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (UnBranchResponse)this.results[0];
			}
		}

		public UnBranchCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}