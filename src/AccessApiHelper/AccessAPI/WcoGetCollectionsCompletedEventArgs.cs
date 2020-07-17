using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WcoGetCollectionsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetCollectionsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetCollectionsResponse)this.results[0];
			}
		}

		public WcoGetCollectionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}