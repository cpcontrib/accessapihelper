using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateTemplateCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateTemplateResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateTemplateResponse)this.results[0];
			}
		}

		public CreateTemplateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}