using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetPublishHistoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetPublishHistoryResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetPublishHistoryResponse)this.results[0];
			}
		}

		public GetAssetPublishHistoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}