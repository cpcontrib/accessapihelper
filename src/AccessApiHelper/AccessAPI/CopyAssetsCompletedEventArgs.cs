using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CopyAssetsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CopyAssetsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CopyAssetsResponse)this.results[0];
			}
		}

		public CopyAssetsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}