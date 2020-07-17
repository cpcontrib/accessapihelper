using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetSite24x7DataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetSite24x7Response Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetSite24x7Response)this.results[0];
			}
		}

		public GetSite24x7DataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}