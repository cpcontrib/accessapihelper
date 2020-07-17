using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UserData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UserData : INotifyPropertyChanged
	{
		private string AvatarField;

		private string CellField;

		private DateTime? CreatedDateField;

		private short? DepartmentIdField;

		private string DescriptionField;

		private string EmailField;

		private bool EnabledField;

		private DateTime? EulaDateField;

		private DateTime? ExpiresField;

		private string ExtensionField;

		private string FaxField;

		private string FnameField;

		private string FullNameField;

		private ICollection<GroupData> GroupsField;

		private int IdField;

		private string IdpNameField;

		private string LastLoginAddrField;

		private DateTime? LastLoginAttemptField;

		private DateTime? LastLoginDateField;

		private string LnameField;

		private short? LocationIdField;

		private int? LoginAttemptsField;

		private string PagerField;

		private string PhoneField;

		private PreferenceData PreferencesField;

		private short? TitleIdField;

		private string UsernameField;

		[DataMember]
		public string Avatar
		{
			get
			{
				return this.AvatarField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AvatarField, value))
				{
					this.AvatarField = value;
					this.RaisePropertyChanged("Avatar");
				}
			}
		}

		[DataMember]
		public string Cell
		{
			get
			{
				return this.CellField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CellField, value))
				{
					this.CellField = value;
					this.RaisePropertyChanged("Cell");
				}
			}
		}

		[DataMember]
		public DateTime? CreatedDate
		{
			get
			{
				return this.CreatedDateField;
			}
			set
			{
				if (!this.CreatedDateField.Equals(value))
				{
					this.CreatedDateField = value;
					this.RaisePropertyChanged("CreatedDate");
				}
			}
		}

		[DataMember]
		public short? DepartmentId
		{
			get
			{
				return this.DepartmentIdField;
			}
			set
			{
				if (!this.DepartmentIdField.Equals(value))
				{
					this.DepartmentIdField = value;
					this.RaisePropertyChanged("DepartmentId");
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
		public string Email
		{
			get
			{
				return this.EmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EmailField, value))
				{
					this.EmailField = value;
					this.RaisePropertyChanged("Email");
				}
			}
		}

		[DataMember]
		public bool Enabled
		{
			get
			{
				return this.EnabledField;
			}
			set
			{
				if (!this.EnabledField.Equals(value))
				{
					this.EnabledField = value;
					this.RaisePropertyChanged("Enabled");
				}
			}
		}

		[DataMember]
		public DateTime? EulaDate
		{
			get
			{
				return this.EulaDateField;
			}
			set
			{
				if (!this.EulaDateField.Equals(value))
				{
					this.EulaDateField = value;
					this.RaisePropertyChanged("EulaDate");
				}
			}
		}

		[DataMember]
		public DateTime? Expires
		{
			get
			{
				return this.ExpiresField;
			}
			set
			{
				if (!this.ExpiresField.Equals(value))
				{
					this.ExpiresField = value;
					this.RaisePropertyChanged("Expires");
				}
			}
		}

		[DataMember]
		public string Extension
		{
			get
			{
				return this.ExtensionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ExtensionField, value))
				{
					this.ExtensionField = value;
					this.RaisePropertyChanged("Extension");
				}
			}
		}

		[DataMember]
		public string Fax
		{
			get
			{
				return this.FaxField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FaxField, value))
				{
					this.FaxField = value;
					this.RaisePropertyChanged("Fax");
				}
			}
		}

		[DataMember]
		public string Fname
		{
			get
			{
				return this.FnameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FnameField, value))
				{
					this.FnameField = value;
					this.RaisePropertyChanged("Fname");
				}
			}
		}

		[DataMember]
		public string FullName
		{
			get
			{
				return this.FullNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FullNameField, value))
				{
					this.FullNameField = value;
					this.RaisePropertyChanged("FullName");
				}
			}
		}

		[DataMember]
		public ICollection<GroupData> Groups
		{
			get
			{
				return this.GroupsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GroupsField, value))
				{
					this.GroupsField = value;
					this.RaisePropertyChanged("Groups");
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
		public string IdpName
		{
			get
			{
				return this.IdpNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdpNameField, value))
				{
					this.IdpNameField = value;
					this.RaisePropertyChanged("IdpName");
				}
			}
		}

		[DataMember]
		public string LastLoginAddr
		{
			get
			{
				return this.LastLoginAddrField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LastLoginAddrField, value))
				{
					this.LastLoginAddrField = value;
					this.RaisePropertyChanged("LastLoginAddr");
				}
			}
		}

		[DataMember]
		public DateTime? LastLoginAttempt
		{
			get
			{
				return this.LastLoginAttemptField;
			}
			set
			{
				if (!this.LastLoginAttemptField.Equals(value))
				{
					this.LastLoginAttemptField = value;
					this.RaisePropertyChanged("LastLoginAttempt");
				}
			}
		}

		[DataMember]
		public DateTime? LastLoginDate
		{
			get
			{
				return this.LastLoginDateField;
			}
			set
			{
				if (!this.LastLoginDateField.Equals(value))
				{
					this.LastLoginDateField = value;
					this.RaisePropertyChanged("LastLoginDate");
				}
			}
		}

		[DataMember]
		public string Lname
		{
			get
			{
				return this.LnameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LnameField, value))
				{
					this.LnameField = value;
					this.RaisePropertyChanged("Lname");
				}
			}
		}

		[DataMember]
		public short? LocationId
		{
			get
			{
				return this.LocationIdField;
			}
			set
			{
				if (!this.LocationIdField.Equals(value))
				{
					this.LocationIdField = value;
					this.RaisePropertyChanged("LocationId");
				}
			}
		}

		[DataMember]
		public int? LoginAttempts
		{
			get
			{
				return this.LoginAttemptsField;
			}
			set
			{
				if (!this.LoginAttemptsField.Equals(value))
				{
					this.LoginAttemptsField = value;
					this.RaisePropertyChanged("LoginAttempts");
				}
			}
		}

		[DataMember]
		public string Pager
		{
			get
			{
				return this.PagerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PagerField, value))
				{
					this.PagerField = value;
					this.RaisePropertyChanged("Pager");
				}
			}
		}

		[DataMember]
		public string Phone
		{
			get
			{
				return this.PhoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PhoneField, value))
				{
					this.PhoneField = value;
					this.RaisePropertyChanged("Phone");
				}
			}
		}

		[DataMember]
		public PreferenceData Preferences
		{
			get
			{
				return this.PreferencesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PreferencesField, value))
				{
					this.PreferencesField = value;
					this.RaisePropertyChanged("Preferences");
				}
			}
		}

		[DataMember]
		public short? TitleId
		{
			get
			{
				return this.TitleIdField;
			}
			set
			{
				if (!this.TitleIdField.Equals(value))
				{
					this.TitleIdField = value;
					this.RaisePropertyChanged("TitleId");
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

		public UserData()
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