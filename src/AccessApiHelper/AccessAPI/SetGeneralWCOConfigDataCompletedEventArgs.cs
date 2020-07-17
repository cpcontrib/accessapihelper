using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetGeneralWCOConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetGeneralWCOConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetGeneralWCOConfigDataResponse)this.results[0];
			}
		}

		public SetGeneralWCOConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}