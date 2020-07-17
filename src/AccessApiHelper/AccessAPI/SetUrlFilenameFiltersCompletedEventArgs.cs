using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetUrlFilenameFiltersCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetUrlFilenameFiltersResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetUrlFilenameFiltersResponse)this.results[0];
			}
		}

		public SetUrlFilenameFiltersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}