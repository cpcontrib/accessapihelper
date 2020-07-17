using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RenderInputTemplateCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public RenderInputTemplateResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (RenderInputTemplateResponse)this.results[0];
			}
		}

		public RenderInputTemplateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}