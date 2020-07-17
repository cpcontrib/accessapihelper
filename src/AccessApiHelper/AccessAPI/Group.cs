using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Group", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class Group : INotifyPropertyChanged
	{
		private DateTime? created_dateField;

		private string descriptionField;

		private short idField;

		private string nameField;

		[DataMember]
		public DateTime? created_date
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
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.descriptionField, value))
				{
					this.descriptionField = value;
					this.RaisePropertyChanged("description");
				}
			}
		}

		[DataMember]
		public short id
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.nameField, value))
				{
					this.nameField = value;
					this.RaisePropertyChanged("name");
				}
			}
		}

		public Group()
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