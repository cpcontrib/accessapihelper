using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetResponse)this.results[0];
			}
		}

		public GetAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}