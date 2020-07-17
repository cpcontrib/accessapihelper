using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateCollectionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateCollectionResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateCollectionResponse)this.results[0];
			}
		}

		public CreateCollectionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}