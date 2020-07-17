using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SubmitSuportTicketRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SubmitSuportTicketRequest : INotifyPropertyChanged
	{
		private ICollection<EmailAttachment> AttachmentsField;

		private string BodyField;

		private string DebugInfoField;

		private string InstanceNameField;

		private string ServerNameField;

		private string SubjectField;

		private string TicketTypeField;

		private string UserEmailField;

		private string UserNameField;

		private string UserPhoneField;

		[DataMember]
		public ICollection<EmailAttachment> Attachments
		{
			get
			{
				return this.AttachmentsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AttachmentsField, value))
				{
					this.AttachmentsField = value;
					this.RaisePropertyChanged("Attachments");
				}
			}
		}

		[DataMember]
		public string Body
		{
			get
			{
				return this.BodyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BodyField, value))
				{
					this.BodyField = value;
					this.RaisePropertyChanged("Body");
				}
			}
		}

		[DataMember]
		public string DebugInfo
		{
			get
			{
				return this.DebugInfoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DebugInfoField, value))
				{
					this.DebugInfoField = value;
					this.RaisePropertyChanged("DebugInfo");
				}
			}
		}

		[DataMember]
		public string InstanceName
		{
			get
			{
				return this.InstanceNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InstanceNameField, value))
				{
					this.InstanceNameField = value;
					this.RaisePropertyChanged("InstanceName");
				}
			}
		}

		[DataMember]
		public string ServerName
		{
			get
			{
				return this.ServerNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ServerNameField, value))
				{
					this.ServerNameField = value;
					this.RaisePropertyChanged("ServerName");
				}
			}
		}

		[DataMember]
		public string Subject
		{
			get
			{
				return this.SubjectField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SubjectField, value))
				{
					this.SubjectField = value;
					this.RaisePropertyChanged("Subject");
				}
			}
		}

		[DataMember]
		public string TicketType
		{
			get
			{
				return this.TicketTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TicketTypeField, value))
				{
					this.TicketTypeField = value;
					this.RaisePropertyChanged("TicketType");
				}
			}
		}

		[DataMember]
		public string UserEmail
		{
			get
			{
				return this.UserEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserEmailField, value))
				{
					this.UserEmailField = value;
					this.RaisePropertyChanged("UserEmail");
				}
			}
		}

		[DataMember]
		public string UserName
		{
			get
			{
				return this.UserNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserNameField, value))
				{
					this.UserNameField = value;
					this.RaisePropertyChanged("UserName");
				}
			}
		}

		[DataMember]
		public string UserPhone
		{
			get
			{
				return this.UserPhoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserPhoneField, value))
				{
					this.UserPhoneField = value;
					this.RaisePropertyChanged("UserPhone");
				}
			}
		}

		public SubmitSuportTicketRequest()
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