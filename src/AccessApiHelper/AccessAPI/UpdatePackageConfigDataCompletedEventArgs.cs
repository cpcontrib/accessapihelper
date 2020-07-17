using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class UpdatePackageConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public UpdatePackageConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (UpdatePackageConfigDataResponse)this.results[0];
			}
		}

		public UpdatePackageConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}