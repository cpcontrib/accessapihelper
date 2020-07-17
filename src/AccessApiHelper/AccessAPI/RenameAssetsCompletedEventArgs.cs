using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RenameAssetsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public RenameAssetsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (RenameAssetsResponse)this.results[0];
			}
		}

		public RenameAssetsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}