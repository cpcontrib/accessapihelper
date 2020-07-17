using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetLibraryFilesCDCCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetLibraryFilesCDCResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetLibraryFilesCDCResponse)this.results[0];
			}
		}

		public GetLibraryFilesCDCCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}