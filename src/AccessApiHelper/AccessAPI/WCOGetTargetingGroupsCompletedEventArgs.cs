using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class WCOGetTargetingGroupsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WCOGetTargetingGroupsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WCOGetTargetingGroupsResponse)this.results[0];
			}
		}

		public WCOGetTargetingGroupsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}