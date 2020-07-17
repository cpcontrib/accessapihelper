using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CloneGroupCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CloneGroupResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CloneGroupResponse)this.results[0];
			}
		}

		public CloneGroupCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}