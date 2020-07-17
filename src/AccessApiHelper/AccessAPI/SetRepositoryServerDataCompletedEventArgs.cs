using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetRepositoryServerDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetRepositoryServerDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetRepositoryServerDataResponse)this.results[0];
			}
		}

		public SetRepositoryServerDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}