using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetListResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetListResponse)this.results[0];
			}
		}

		public GetAssetListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}