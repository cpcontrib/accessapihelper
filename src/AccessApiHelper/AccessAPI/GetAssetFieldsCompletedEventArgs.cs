using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetFieldsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetFieldsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetFieldsResponse)this.results[0];
			}
		}

		public GetAssetFieldsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}