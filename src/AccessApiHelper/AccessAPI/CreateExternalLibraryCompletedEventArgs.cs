using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateExternalLibraryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateExternalLibraryResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateExternalLibraryResponse)this.results[0];
			}
		}

		public CreateExternalLibraryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}