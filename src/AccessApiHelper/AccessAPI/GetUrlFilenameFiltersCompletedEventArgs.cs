using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetUrlFilenameFiltersCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetUrlFilenameFiltersResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetUrlFilenameFiltersResponse)this.results[0];
			}
		}

		public GetUrlFilenameFiltersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}