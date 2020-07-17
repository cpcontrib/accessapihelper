using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class DeletePackageConfigDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public DeletePackageConfigDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DeletePackageConfigDataResponse)this.results[0];
			}
		}

		public DeletePackageConfigDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}