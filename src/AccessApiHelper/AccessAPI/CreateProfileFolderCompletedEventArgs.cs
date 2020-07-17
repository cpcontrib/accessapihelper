using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class CreateProfileFolderCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public CreateProfileResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (CreateProfileResponse)this.results[0];
			}
		}

		public CreateProfileFolderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}