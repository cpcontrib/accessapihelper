using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RecompileTemplatesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public RecompileTemplatesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (RecompileTemplatesResponse)this.results[0];
			}
		}

		public RecompileTemplatesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}