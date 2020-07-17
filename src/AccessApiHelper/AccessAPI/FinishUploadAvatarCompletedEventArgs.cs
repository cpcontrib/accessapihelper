using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class FinishUploadAvatarCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public FinishUploadAvatarResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (FinishUploadAvatarResponse)this.results[0];
			}
		}

		public FinishUploadAvatarCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}