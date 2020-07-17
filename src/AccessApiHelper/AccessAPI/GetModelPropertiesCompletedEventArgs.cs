using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetModelPropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetModelPropertiesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetModelPropertiesResponse)this.results[0];
			}
		}

		public GetModelPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}