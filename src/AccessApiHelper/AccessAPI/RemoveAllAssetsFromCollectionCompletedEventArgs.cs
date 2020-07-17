using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RemoveAllAssetsFromCollectionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WSResultClass Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WSResultClass)this.results[0];
			}
		}

		public RemoveAllAssetsFromCollectionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}