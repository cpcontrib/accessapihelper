using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SmtpServerData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SmtpServerData : INotifyPropertyChanged
	{
		private string ContentTypeField;

		private string FromAddressField;

		private int IdField;

		private bool IsDeletedField;

		private bool IsInsertedField;

		private bool IsModifiedField;

		private string NameField;

		private string SubjectField;

		private string ToAddressField;

		[DataMember]
		public string ContentType
		{
			get
			{
				return this.ContentTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ContentTypeField, value))
				{
					this.ContentTypeField = value;
					this.RaisePropertyChanged("ContentType");
				}
			}
		}

		[DataMember]
		public string FromAddress
		{
			get
			{
				return this.FromAddressField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FromAddressField, value))
				{
					this.FromAddressField = value;
					this.RaisePropertyChanged("FromAddress");
				}
			}
		}

		[DataMember]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember]
		public bool IsDeleted
		{
			get
			{
				return this.IsDeletedField;
			}
			set
			{
				if (!this.IsDeletedField.Equals(value))
				{
					this.IsDeletedField = value;
					this.RaisePropertyChanged("IsDeleted");
				}
			}
		}

		[DataMember]
		public bool IsInserted
		{
			get
			{
				return this.IsInsertedField;
			}
			set
			{
				if (!this.IsInsertedField.Equals(value))
				{
					this.IsInsertedField = value;
					this.RaisePropertyChanged("IsInserted");
				}
			}
		}

		[DataMember]
		public bool IsModified
		{
			get
			{
				return this.IsModifiedField;
			}
			set
			{
				if (!this.IsModifiedField.Equals(value))
				{
					this.IsModifiedField = value;
					this.RaisePropertyChanged("IsModified");
				}
			}
		}

		[DataMember]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
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
		public string ToAddress
		{
			get
			{
				return this.ToAddressField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ToAddressField, value))
				{
					this.ToAddressField = value;
					this.RaisePropertyChanged("ToAddress");
				}
			}
		}

		public SmtpServerData()
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