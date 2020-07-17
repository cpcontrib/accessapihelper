using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class TestConnectorCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public TestConnectorResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (TestConnectorResponse)this.results[0];
			}
		}

		public TestConnectorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}