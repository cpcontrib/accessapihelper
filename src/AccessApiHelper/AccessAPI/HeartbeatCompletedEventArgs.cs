using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class HeartbeatCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public HeartbeatResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (HeartbeatResponse)this.results[0];
			}
		}

		public HeartbeatCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}