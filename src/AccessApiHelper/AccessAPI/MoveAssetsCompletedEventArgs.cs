using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class MoveAssetsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public MoveAssetsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (MoveAssetsResponse)this.results[0];
			}
		}

		public MoveAssetsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}