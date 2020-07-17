using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace CrownPeak.AccessAPI
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class PrepareUploadAttachmentCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PrepareUploadResponse Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PrepareUploadResponse)this.results[0];
			}
		}

		public PrepareUploadAttachmentCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}