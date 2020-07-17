using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateTemplateFileCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateTemplateFileResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateTemplateFileResponse)this.results[0];
			}
		}

		public CreateTemplateFileCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}