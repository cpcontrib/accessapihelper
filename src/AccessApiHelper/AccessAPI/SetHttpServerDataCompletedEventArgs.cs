using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetHttpServerDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetHttpServerDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetHttpServerDataResponse)this.results[0];
			}
		}

		public SetHttpServerDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}