using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpActivityUser", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class cpActivityUser : INotifyPropertyChanged
	{
		private string AvatarURLField;

		private string EmailField;

		private int IdField;

		private DateTime LastActivityField;

		private DateTime LastLoginField;

		private string NameField;

		private TimeSpan TimeSinceLastActivityField;

		private float TimezoneField;

		private string TitleField;

		private string UserNameField;

		[DataMember]
		public string AvatarURL
		{
			get
			{
				return this.AvatarURLField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AvatarURLField, value))
				{
					this.AvatarURLField = value;
					this.RaisePropertyChanged("AvatarURL");
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
		public DateTime LastActivity
		{
			get
			{
				return this.LastActivityField;
			}
			set
			{
				if (!this.LastActivityField.Equals(value))
				{
					this.LastActivityField = value;
					this.RaisePropertyChanged("LastActivity");
				}
			}
		}

		[DataMember]
		public DateTime LastLogin
		{
			get
			{
				return this.LastLoginField;
			}
			set
			{
				if (!this.LastLoginField.Equals(value))
				{
					this.LastLoginField = value;
					this.RaisePropertyChanged("LastLogin");
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
		public TimeSpan TimeSinceLastActivity
		{
			get
			{
				return this.TimeSinceLastActivityField;
			}
			set
			{
				if (!this.TimeSinceLastActivityField.Equals(value))
				{
					this.TimeSinceLastActivityField = value;
					this.RaisePropertyChanged("TimeSinceLastActivity");
				}
			}
		}

		[DataMember]
		public float Timezone
		{
			get
			{
				return this.TimezoneField;
			}
			set
			{
				if (!this.TimezoneField.Equals(value))
				{
					this.TimezoneField = value;
					this.RaisePropertyChanged("Timezone");
				}
			}
		}

		[DataMember]
		public string Title
		{
			get
			{
				return this.TitleField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TitleField, value))
				{
					this.TitleField = value;
					this.RaisePropertyChanged("Title");
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

		public cpActivityUser()
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