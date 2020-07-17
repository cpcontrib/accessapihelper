using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAssetScheduleCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAssetScheduleResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAssetScheduleResponse)this.results[0];
			}
		}

		public SetAssetScheduleCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}