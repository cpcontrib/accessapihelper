using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RouteAssetCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public RouteAssetResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (RouteAssetResponse)this.results[0];
			}
		}

		public RouteAssetCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}