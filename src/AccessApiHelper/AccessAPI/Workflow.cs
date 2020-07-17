using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Workflow", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class Workflow : INotifyPropertyChanged
	{
		private int asset_idField;

		private DateTime? dateField;

		private string descriptionField;

		private int idField;

		private bool? is_deletedField;

		private int? modified_user_idField;

		private string nameField;

		[DataMember]
		public int asset_id
		{
			get
			{
				return this.asset_idField;
			}
			set
			{
				if (!this.asset_idField.Equals(value))
				{
					this.asset_idField = value;
					this.RaisePropertyChanged("asset_id");
				}
			}
		}

		[DataMember]
		public DateTime? date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				if (!this.dateField.Equals(value))
				{
					this.dateField = value;
					this.RaisePropertyChanged("date");
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
		public bool? is_deleted
		{
			get
			{
				return this.is_deletedField;
			}
			set
			{
				if (!this.is_deletedField.Equals(value))
				{
					this.is_deletedField = value;
					this.RaisePropertyChanged("is_deleted");
				}
			}
		}

		[DataMember]
		public int? modified_user_id
		{
			get
			{
				return this.modified_user_idField;
			}
			set
			{
				if (!this.modified_user_idField.Equals(value))
				{
					this.modified_user_idField = value;
					this.RaisePropertyChanged("modified_user_id");
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

		public Workflow()
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