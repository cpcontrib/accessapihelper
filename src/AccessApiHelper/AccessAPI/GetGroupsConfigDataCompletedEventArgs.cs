using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGroupsConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetGroupsConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetGroupsConfigDataResponse)this.results[0];
			}
		}

		public GetGroupsConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}