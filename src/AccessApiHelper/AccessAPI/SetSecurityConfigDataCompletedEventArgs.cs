using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetSecurityConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetSecurityConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetSecurityConfigDataResponse)this.results[0];
			}
		}

		public SetSecurityConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}