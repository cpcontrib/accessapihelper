using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetFolderAssetFieldsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetFolderAssetFieldsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetFolderAssetFieldsResponse)this.results[0];
			}
		}

		public GetFolderAssetFieldsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}