using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAdvancedSearchOptionsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAdvancedSearchOptionsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAdvancedSearchOptionsResponse)this.results[0];
			}
		}

		public GetAdvancedSearchOptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}