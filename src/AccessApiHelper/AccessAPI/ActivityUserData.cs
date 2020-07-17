using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ActivityUserData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ActivityUserData : INotifyPropertyChanged
	{
		private string AvatarField;

		private string FnameField;

		private string FullNameField;

		private int IdField;

		private string LnameField;

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

		public ActivityUserData()
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