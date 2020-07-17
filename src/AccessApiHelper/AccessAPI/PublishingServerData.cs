using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingServerData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingServerData : INotifyPropertyChanged
	{
		private string ConfiguredHostNameField;

		private string ConfiguredPathField;

		private bool EnabledField;

		private bool EncodeUTF8Field;

		private int HttpIdField;

		private int IdField;

		private bool IncludeInAnalyticsField;

		private bool IsDeletedField;

		private bool IsInsertedField;

		private bool IsModifiedField;

		private string NameField;

		private int OdbcIdField;

		private cpConstPackageStateType PackageStateField;

		private int RepositoryIdField;

		private int SmtpIdField;

		private int SoapIdField;

		[DataMember]
		public string ConfiguredHostName
		{
			get
			{
				return this.ConfiguredHostNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ConfiguredHostNameField, value))
				{
					this.ConfiguredHostNameField = value;
					this.RaisePropertyChanged("ConfiguredHostName");
				}
			}
		}

		[DataMember]
		public string ConfiguredPath
		{
			get
			{
				return this.ConfiguredPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ConfiguredPathField, value))
				{
					this.ConfiguredPathField = value;
					this.RaisePropertyChanged("ConfiguredPath");
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
		public bool EncodeUTF8
		{
			get
			{
				return this.EncodeUTF8Field;
			}
			set
			{
				if (!this.EncodeUTF8Field.Equals(value))
				{
					this.EncodeUTF8Field = value;
					this.RaisePropertyChanged("EncodeUTF8");
				}
			}
		}

		[DataMember]
		public int HttpId
		{
			get
			{
				return this.HttpIdField;
			}
			set
			{
				if (!this.HttpIdField.Equals(value))
				{
					this.HttpIdField = value;
					this.RaisePropertyChanged("HttpId");
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
		public bool IncludeInAnalytics
		{
			get
			{
				return this.IncludeInAnalyticsField;
			}
			set
			{
				if (!this.IncludeInAnalyticsField.Equals(value))
				{
					this.IncludeInAnalyticsField = value;
					this.RaisePropertyChanged("IncludeInAnalytics");
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
		public int OdbcId
		{
			get
			{
				return this.OdbcIdField;
			}
			set
			{
				if (!this.OdbcIdField.Equals(value))
				{
					this.OdbcIdField = value;
					this.RaisePropertyChanged("OdbcId");
				}
			}
		}

		[DataMember]
		public cpConstPackageStateType PackageState
		{
			get
			{
				return this.PackageStateField;
			}
			set
			{
				if (!this.PackageStateField.Equals(value))
				{
					this.PackageStateField = value;
					this.RaisePropertyChanged("PackageState");
				}
			}
		}

		[DataMember]
		public int RepositoryId
		{
			get
			{
				return this.RepositoryIdField;
			}
			set
			{
				if (!this.RepositoryIdField.Equals(value))
				{
					this.RepositoryIdField = value;
					this.RaisePropertyChanged("RepositoryId");
				}
			}
		}

		[DataMember]
		public int SmtpId
		{
			get
			{
				return this.SmtpIdField;
			}
			set
			{
				if (!this.SmtpIdField.Equals(value))
				{
					this.SmtpIdField = value;
					this.RaisePropertyChanged("SmtpId");
				}
			}
		}

		[DataMember]
		public int SoapId
		{
			get
			{
				return this.SoapIdField;
			}
			set
			{
				if (!this.SoapIdField.Equals(value))
				{
					this.SoapIdField = value;
					this.RaisePropertyChanged("SoapId");
				}
			}
		}

		public PublishingServerData()
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