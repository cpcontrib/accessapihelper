using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetGeneralPropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GeneralPropertiesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GeneralPropertiesResponse)this.results[0];
			}
		}

		public GetGeneralPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}