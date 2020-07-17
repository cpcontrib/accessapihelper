using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetProviderSettingsConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetProviderSettingsConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetProviderSettingsConfigDataResponse)this.results[0];
			}
		}

		public GetProviderSettingsConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}