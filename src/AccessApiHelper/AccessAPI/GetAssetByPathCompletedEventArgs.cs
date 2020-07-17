using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetByPathCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetByPathResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetByPathResponse)this.results[0];
			}
		}

		public GetAssetByPathCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}