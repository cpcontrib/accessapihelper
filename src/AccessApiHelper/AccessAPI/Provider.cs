using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Provider", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class Provider : INotifyPropertyChanged
	{
		private string ClassicCourtesyUrlField;

		private string CourtesyUrlField;

		private string DescriptionField;

		private bool DisableSignOutField;

		private string DomainField;

		private string FriendlyNameField;

		private string HomeRealmField;

		private string NameField;

		private bool ShowBrowserField;

		[DataMember]
		public string ClassicCourtesyUrl
		{
			get
			{
				return this.ClassicCourtesyUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ClassicCourtesyUrlField, value))
				{
					this.ClassicCourtesyUrlField = value;
					this.RaisePropertyChanged("ClassicCourtesyUrl");
				}
			}
		}

		[DataMember]
		public string CourtesyUrl
		{
			get
			{
				return this.CourtesyUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CourtesyUrlField, value))
				{
					this.CourtesyUrlField = value;
					this.RaisePropertyChanged("CourtesyUrl");
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
		public bool DisableSignOut
		{
			get
			{
				return this.DisableSignOutField;
			}
			set
			{
				if (!this.DisableSignOutField.Equals(value))
				{
					this.DisableSignOutField = value;
					this.RaisePropertyChanged("DisableSignOut");
				}
			}
		}

		[DataMember]
		public string Domain
		{
			get
			{
				return this.DomainField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DomainField, value))
				{
					this.DomainField = value;
					this.RaisePropertyChanged("Domain");
				}
			}
		}

		[DataMember]
		public string FriendlyName
		{
			get
			{
				return this.FriendlyNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FriendlyNameField, value))
				{
					this.FriendlyNameField = value;
					this.RaisePropertyChanged("FriendlyName");
				}
			}
		}

		[DataMember]
		public string HomeRealm
		{
			get
			{
				return this.HomeRealmField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HomeRealmField, value))
				{
					this.HomeRealmField = value;
					this.RaisePropertyChanged("HomeRealm");
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
		public bool ShowBrowser
		{
			get
			{
				return this.ShowBrowserField;
			}
			set
			{
				if (!this.ShowBrowserField.Equals(value))
				{
					this.ShowBrowserField = value;
					this.RaisePropertyChanged("ShowBrowser");
				}
			}
		}

		public Provider()
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