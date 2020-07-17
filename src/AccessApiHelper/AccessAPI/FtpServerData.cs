using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FtpServerData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FtpServerData : INotifyPropertyChanged
	{
		private bool ActiveModeField;

		private bool GroupExecuteField;

		private bool GroupReadField;

		private bool GroupWriteField;

		private string HostnameField;

		private int IdField;

		private int InUseField;

		private bool IsDeletedField;

		private bool IsInsertedField;

		private bool IsModifiedField;

		private string NameField;

		private bool OwnerExecuteField;

		private bool OwnerReadField;

		private bool OwnerWriteField;

		private string PasswordField;

		private string RootPathField;

		private bool SafeWriteField;

		private bool SecureModeField;

		private string UsernameField;

		private bool WorldExecuteField;

		private bool WorldReadField;

		private bool WorldWriteField;

		[DataMember]
		public bool ActiveMode
		{
			get
			{
				return this.ActiveModeField;
			}
			set
			{
				if (!this.ActiveModeField.Equals(value))
				{
					this.ActiveModeField = value;
					this.RaisePropertyChanged("ActiveMode");
				}
			}
		}

		[DataMember]
		public bool GroupExecute
		{
			get
			{
				return this.GroupExecuteField;
			}
			set
			{
				if (!this.GroupExecuteField.Equals(value))
				{
					this.GroupExecuteField = value;
					this.RaisePropertyChanged("GroupExecute");
				}
			}
		}

		[DataMember]
		public bool GroupRead
		{
			get
			{
				return this.GroupReadField;
			}
			set
			{
				if (!this.GroupReadField.Equals(value))
				{
					this.GroupReadField = value;
					this.RaisePropertyChanged("GroupRead");
				}
			}
		}

		[DataMember]
		public bool GroupWrite
		{
			get
			{
				return this.GroupWriteField;
			}
			set
			{
				if (!this.GroupWriteField.Equals(value))
				{
					this.GroupWriteField = value;
					this.RaisePropertyChanged("GroupWrite");
				}
			}
		}

		[DataMember]
		public string Hostname
		{
			get
			{
				return this.HostnameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HostnameField, value))
				{
					this.HostnameField = value;
					this.RaisePropertyChanged("Hostname");
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
		public int InUse
		{
			get
			{
				return this.InUseField;
			}
			set
			{
				if (!this.InUseField.Equals(value))
				{
					this.InUseField = value;
					this.RaisePropertyChanged("InUse");
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
		public bool OwnerExecute
		{
			get
			{
				return this.OwnerExecuteField;
			}
			set
			{
				if (!this.OwnerExecuteField.Equals(value))
				{
					this.OwnerExecuteField = value;
					this.RaisePropertyChanged("OwnerExecute");
				}
			}
		}

		[DataMember]
		public bool OwnerRead
		{
			get
			{
				return this.OwnerReadField;
			}
			set
			{
				if (!this.OwnerReadField.Equals(value))
				{
					this.OwnerReadField = value;
					this.RaisePropertyChanged("OwnerRead");
				}
			}
		}

		[DataMember]
		public bool OwnerWrite
		{
			get
			{
				return this.OwnerWriteField;
			}
			set
			{
				if (!this.OwnerWriteField.Equals(value))
				{
					this.OwnerWriteField = value;
					this.RaisePropertyChanged("OwnerWrite");
				}
			}
		}

		[DataMember]
		public string Password
		{
			get
			{
				return this.PasswordField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PasswordField, value))
				{
					this.PasswordField = value;
					this.RaisePropertyChanged("Password");
				}
			}
		}

		[DataMember]
		public string RootPath
		{
			get
			{
				return this.RootPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RootPathField, value))
				{
					this.RootPathField = value;
					this.RaisePropertyChanged("RootPath");
				}
			}
		}

		[DataMember]
		public bool SafeWrite
		{
			get
			{
				return this.SafeWriteField;
			}
			set
			{
				if (!this.SafeWriteField.Equals(value))
				{
					this.SafeWriteField = value;
					this.RaisePropertyChanged("SafeWrite");
				}
			}
		}

		[DataMember]
		public bool SecureMode
		{
			get
			{
				return this.SecureModeField;
			}
			set
			{
				if (!this.SecureModeField.Equals(value))
				{
					this.SecureModeField = value;
					this.RaisePropertyChanged("SecureMode");
				}
			}
		}

		[DataMember]
		public string Username
		{
			get
			{
				return this.UsernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UsernameField, value))
				{
					this.UsernameField = value;
					this.RaisePropertyChanged("Username");
				}
			}
		}

		[DataMember]
		public bool WorldExecute
		{
			get
			{
				return this.WorldExecuteField;
			}
			set
			{
				if (!this.WorldExecuteField.Equals(value))
				{
					this.WorldExecuteField = value;
					this.RaisePropertyChanged("WorldExecute");
				}
			}
		}

		[DataMember]
		public bool WorldRead
		{
			get
			{
				return this.WorldReadField;
			}
			set
			{
				if (!this.WorldReadField.Equals(value))
				{
					this.WorldReadField = value;
					this.RaisePropertyChanged("WorldRead");
				}
			}
		}

		[DataMember]
		public bool WorldWrite
		{
			get
			{
				return this.WorldWriteField;
			}
			set
			{
				if (!this.WorldWriteField.Equals(value))
				{
					this.WorldWriteField = value;
					this.RaisePropertyChanged("WorldWrite");
				}
			}
		}

		public FtpServerData()
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