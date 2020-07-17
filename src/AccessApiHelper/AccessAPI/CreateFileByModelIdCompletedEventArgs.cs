using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateFileByModelIdCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateFileByModelIdResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateFileByModelIdResponse)this.results[0];
			}
		}

		public CreateFileByModelIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}