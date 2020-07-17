using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="EmailAttachment", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class EmailAttachment : INotifyPropertyChanged
	{
		private string AttachmentDataField;

		private string AttachmentNameField;

		[DataMember]
		public string AttachmentData
		{
			get
			{
				return this.AttachmentDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AttachmentDataField, value))
				{
					this.AttachmentDataField = value;
					this.RaisePropertyChanged("AttachmentData");
				}
			}
		}

		[DataMember]
		public string AttachmentName
		{
			get
			{
				return this.AttachmentNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AttachmentNameField, value))
				{
					this.AttachmentNameField = value;
					this.RaisePropertyChanged("AttachmentName");
				}
			}
		}

		public EmailAttachment()
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