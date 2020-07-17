using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetProfilesByAssetIdCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetProfilesByAssetIdResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetProfilesByAssetIdResponse)this.results[0];
			}
		}

		public WCOGetProfilesByAssetIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}