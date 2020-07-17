using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAssetPathByIdCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetAssetPathByIdResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetAssetPathByIdResponse)this.results[0];
			}
		}

		public GetAssetPathByIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}