using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetVersionsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetVersionsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetVersionsResponse)this.results[0];
			}
		}

		public GetAssetVersionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}