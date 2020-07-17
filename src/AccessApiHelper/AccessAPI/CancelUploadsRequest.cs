using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CancelUploadsRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CancelUploadsRequest : INotifyPropertyChanged
	{
		private ICollection<CancelUploadRequest> UploadTicketsField;

		[DataMember]
		public ICollection<CancelUploadRequest> UploadTickets
		{
			get
			{
				return this.UploadTicketsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UploadTicketsField, value))
				{
					this.UploadTicketsField = value;
					this.RaisePropertyChanged("UploadTickets");
				}
			}
		}

		public CancelUploadsRequest()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}