using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetGeneralConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetGeneralConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetGeneralConfigDataResponse)this.results[0];
			}
		}

		public SetGeneralConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}