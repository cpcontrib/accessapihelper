using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGroupsDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetGroupsDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetGroupsDataResponse)this.results[0];
			}
		}

		public GetGroupsDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}