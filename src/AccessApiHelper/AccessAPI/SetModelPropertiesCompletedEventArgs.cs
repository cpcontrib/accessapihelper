using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetModelPropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetModelPropertiesResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetModelPropertiesResponse)this.results[0];
			}
		}

		public SetModelPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}