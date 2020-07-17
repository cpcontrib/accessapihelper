using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDepartmentsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public GetDepartmentsResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GetDepartmentsResponse)this.results[0];
			}
		}

		public GetDepartmentsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}