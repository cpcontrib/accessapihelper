using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class OpenTemplateCDCCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public OpenTemplateCDCResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (OpenTemplateCDCResponse)this.results[0];
			}
		}

		public OpenTemplateCDCCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}