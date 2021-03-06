using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateSiteRootCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateSiteRootResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateSiteRootResponse)this.results[0];
			}
		}

		public CreateSiteRootCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}