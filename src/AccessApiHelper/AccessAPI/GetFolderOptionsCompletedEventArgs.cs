using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetFolderOptionsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetFolderOptionsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetFolderOptionsResponse)this.results[0];
			}
		}

		public GetFolderOptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}