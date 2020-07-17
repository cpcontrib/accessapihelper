using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateProjectCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateProjectResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateProjectResponse)this.results[0];
			}
		}

		public CreateProjectCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}