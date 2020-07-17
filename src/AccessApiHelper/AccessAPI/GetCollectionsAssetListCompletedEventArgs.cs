using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetCollectionsAssetListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetCollectionsAssetListResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetCollectionsAssetListResponse)this.results[0];
			}
		}

		public GetCollectionsAssetListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}