using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class FinishUploadAttachmentCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public FinishUploadAttachmentResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (FinishUploadAttachmentResponse)this.results[0];
			}
		}

		public FinishUploadAttachmentCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}