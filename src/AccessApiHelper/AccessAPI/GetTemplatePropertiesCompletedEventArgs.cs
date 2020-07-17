using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetTemplatePropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public TemplatePropertiesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (TemplatePropertiesResponse)this.results[0];
			}
		}

		public GetTemplatePropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}