using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="OdbcServerData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class OdbcServerData : INotifyPropertyChanged
	{
		private byte ConnectionTypeField;

		private string DatabaseField;

		private int IdField;

		private bool IsDeletedField;

		private bool IsInsertedField;

		private bool IsModifiedField;

		private string NameField;

		private string OdbcPasswordField;

		private string OdbcUsernameField;

		private string ServerField;

		[DataMember]
		public byte ConnectionType
		{
			get
			{
				return this.ConnectionTypeField;
			}
			set
			{
				if (!this.ConnectionTypeField.Equals(value))
				{
					this.ConnectionTypeField = value;
					this.RaisePropertyChanged("ConnectionType");
				}
			}
		}

		[DataMember]
		public string Database
		{
			get
			{
				return this.DatabaseField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DatabaseField, value))
				{
					this.DatabaseField = value;
					this.RaisePropertyChanged("Database");
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
		public string OdbcPassword
		{
			get
			{
				return this.OdbcPasswordField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OdbcPasswordField, value))
				{
					this.OdbcPasswordField = value;
					this.RaisePropertyChanged("OdbcPassword");
				}
			}
		}

		[DataMember]
		public string OdbcUsername
		{
			get
			{
				return this.OdbcUsernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OdbcUsernameField, value))
				{
					this.OdbcUsernameField = value;
					this.RaisePropertyChanged("OdbcUsername");
				}
			}
		}

		[DataMember]
		public string Server
		{
			get
			{
				return this.ServerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ServerField, value))
				{
					this.ServerField = value;
					this.RaisePropertyChanged("Server");
				}
			}
		}

		public OdbcServerData()
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