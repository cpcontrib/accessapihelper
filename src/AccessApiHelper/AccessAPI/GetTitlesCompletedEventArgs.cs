using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetTitlesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetTitlesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetTitlesResponse)this.results[0];
			}
		}

		public GetTitlesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}