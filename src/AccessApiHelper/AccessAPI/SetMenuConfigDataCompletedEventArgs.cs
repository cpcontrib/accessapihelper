using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetMenuConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetMenuConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetMenuConfigDataResponse)this.results[0];
			}
		}

		public SetMenuConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}