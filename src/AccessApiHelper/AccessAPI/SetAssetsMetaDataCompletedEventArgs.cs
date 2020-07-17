using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SetAssetsMetaDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SetAssetsMetaDataResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SetAssetsMetaDataResponse)this.results[0];
			}
		}

		public SetAssetsMetaDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}