using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetUserPreferenceDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetUserPreferenceDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetUserPreferenceDataResponse)this.results[0];
			}
		}

		public SetUserPreferenceDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}