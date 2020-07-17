using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateLibraryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateLibraryResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateLibraryResponse)this.results[0];
			}
		}

		public CreateLibraryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}