using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetRelatedAssetsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetRelatedAssetsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetRelatedAssetsResponse)this.results[0];
			}
		}

		public GetRelatedAssetsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}