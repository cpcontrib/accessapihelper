using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetScheduleCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetScheduleResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetScheduleResponse)this.results[0];
			}
		}

		public GetAssetScheduleCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}