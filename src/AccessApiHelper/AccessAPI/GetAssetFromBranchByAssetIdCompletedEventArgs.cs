using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetFromBranchByAssetIdCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetByGoToQueryResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetByGoToQueryResponse)this.results[0];
			}
		}

		public GetAssetFromBranchByAssetIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}