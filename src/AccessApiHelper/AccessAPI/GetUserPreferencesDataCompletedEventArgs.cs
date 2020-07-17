using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetUserPreferencesDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetUserPreferencesDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetUserPreferencesDataResponse)this.results[0];
			}
		}

		public GetUserPreferencesDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}