using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetLibraryFilesZipCDCCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetLibraryFilesZipCDCResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetLibraryFilesZipCDCResponse)this.results[0];
			}
		}

		public GetLibraryFilesZipCDCCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}