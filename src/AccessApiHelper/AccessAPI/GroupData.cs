using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GroupData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GroupData : INotifyPropertyChanged
	{
		private DateTime? DateCreatedField;

		private string DescriptionField;

		private int IdField;

		private string NameField;

		private ICollection<ActivityUserData> UsersField;

		[DataMember]
		public DateTime? DateCreated
		{
			get
			{
				return this.DateCreatedField;
			}
			set
			{
				if (!this.DateCreatedField.Equals(value))
				{
					this.DateCreatedField = value;
					this.RaisePropertyChanged("DateCreated");
				}
			}
		}

		[DataMember]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DescriptionField, value))
				{
					this.DescriptionField = value;
					this.RaisePropertyChanged("Description");
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
		public ICollection<ActivityUserData> Users
		{
			get
			{
				return this.UsersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UsersField, value))
				{
					this.UsersField = value;
					this.RaisePropertyChanged("Users");
				}
			}
		}

		public GroupData()
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