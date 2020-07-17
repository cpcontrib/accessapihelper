using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="EmailSender", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class EmailSender : INotifyPropertyChanged
	{
		private DateTime? changed_dateField;

		private DateTime created_dateField;

		private string email_addressField;

		private int idField;

		private byte statusField;

		[DataMember]
		public DateTime? changed_date
		{
			get
			{
				return this.changed_dateField;
			}
			set
			{
				if (!this.changed_dateField.Equals(value))
				{
					this.changed_dateField = value;
					this.RaisePropertyChanged("changed_date");
				}
			}
		}

		[DataMember]
		public DateTime created_date
		{
			get
			{
				return this.created_dateField;
			}
			set
			{
				if (!this.created_dateField.Equals(value))
				{
					this.created_dateField = value;
					this.RaisePropertyChanged("created_date");
				}
			}
		}

		[DataMember]
		public string email_address
		{
			get
			{
				return this.email_addressField;
			}
			set
			{
				if (!object.ReferenceEquals(this.email_addressField, value))
				{
					this.email_addressField = value;
					this.RaisePropertyChanged("email_address");
				}
			}
		}

		[DataMember]
		public int id
		{
			get
			{
				return this.idField;
			}
			set
			{
				if (!this.idField.Equals(value))
				{
					this.idField = value;
					this.RaisePropertyChanged("id");
				}
			}
		}

		[DataMember]
		public byte status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				if (!this.statusField.Equals(value))
				{
					this.statusField = value;
					this.RaisePropertyChanged("status");
				}
			}
		}

		public EmailSender()
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