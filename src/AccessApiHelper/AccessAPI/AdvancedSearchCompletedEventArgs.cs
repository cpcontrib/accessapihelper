using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class AdvancedSearchCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public AdvancedSearchResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (AdvancedSearchResponse)this.results[0];
			}
		}

		public AdvancedSearchCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}