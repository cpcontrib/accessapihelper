using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetMetaDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetMetaDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetMetaDataResponse)this.results[0];
			}
		}

		public GetAssetMetaDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}