using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetWorklistPreferencesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetWorklistPreferenceResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetWorklistPreferenceResponse)this.results[0];
			}
		}

		public SetWorklistPreferencesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}