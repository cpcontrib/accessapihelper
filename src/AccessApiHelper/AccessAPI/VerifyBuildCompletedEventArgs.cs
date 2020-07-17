using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class VerifyBuildCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public VerifyBuildResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (VerifyBuildResponse)this.results[0];
			}
		}

		public VerifyBuildCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}