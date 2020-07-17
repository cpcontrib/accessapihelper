using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetMenuConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetMenuConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetMenuConfigDataResponse)this.results[0];
			}
		}

		public GetMenuConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}