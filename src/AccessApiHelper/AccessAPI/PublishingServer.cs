using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingServer", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingServer : INotifyPropertyChanged
	{
		private CrownPeak.AccessAPI.RepositoryServer RepositoryServerField;

		private string configured_hostnameField;

		private string configured_pathField;

		private bool enabledField;

		private bool encodeUTF8Field;

		private int? http_idField;

		private int idField;

		private string nameField;

		private int? odbc_idField;

		private byte package_stateField;

		private int? repository_idField;

		private int? smtp_idField;

		private int? soap_idField;

		[DataMember]
		public string configured_hostname
		{
			get
			{
				return this.configured_hostnameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.configured_hostnameField, value))
				{
					this.configured_hostnameField = value;
					this.RaisePropertyChanged("configured_hostname");
				}
			}
		}

		[DataMember]
		public string configured_path
		{
			get
			{
				return this.configured_pathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.configured_pathField, value))
				{
					this.configured_pathField = value;
					this.RaisePropertyChanged("configured_path");
				}
			}
		}

		[DataMember]
		public bool enabled
		{
			get
			{
				return this.enabledField;
			}
			set
			{
				if (!this.enabledField.Equals(value))
				{
					this.enabledField = value;
					this.RaisePropertyChanged("enabled");
				}
			}
		}

		[DataMember]
		public bool encodeUTF8
		{
			get
			{
				return this.encodeUTF8Field;
			}
			set
			{
				if (!this.encodeUTF8Field.Equals(value))
				{
					this.encodeUTF8Field = value;
					this.RaisePropertyChanged("encodeUTF8");
				}
			}
		}

		[DataMember]
		public int? http_id
		{
			get
			{
				return this.http_idField;
			}
			set
			{
				if (!this.http_idField.Equals(value))
				{
					this.http_idField = value;
					this.RaisePropertyChanged("http_id");
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

		[DataMember]
		public int? odbc_id
		{
			get
			{
				return this.odbc_idField;
			}
			set
			{
				if (!this.odbc_idField.Equals(value))
				{
					this.odbc_idField = value;
					this.RaisePropertyChanged("odbc_id");
				}
			}
		}

		[DataMember]
		public byte package_state
		{
			get
			{
				return this.package_stateField;
			}
			set
			{
				if (!this.package_stateField.Equals(value))
				{
					this.package_stateField = value;
					this.RaisePropertyChanged("package_state");
				}
			}
		}

		[DataMember]
		public int? repository_id
		{
			get
			{
				return this.repository_idField;
			}
			set
			{
				if (!this.repository_idField.Equals(value))
				{
					this.repository_idField = value;
					this.RaisePropertyChanged("repository_id");
				}
			}
		}

		[DataMember]
		public CrownPeak.AccessAPI.RepositoryServer RepositoryServer
		{
			get
			{
				return this.RepositoryServerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RepositoryServerField, value))
				{
					this.RepositoryServerField = value;
					this.RaisePropertyChanged("RepositoryServer");
				}
			}
		}

		[DataMember]
		public int? smtp_id
		{
			get
			{
				return this.smtp_idField;
			}
			set
			{
				if (!this.smtp_idField.Equals(value))
				{
					this.smtp_idField = value;
					this.RaisePropertyChanged("smtp_id");
				}
			}
		}

		[DataMember]
		public int? soap_id
		{
			get
			{
				return this.soap_idField;
			}
			set
			{
				if (!this.soap_idField.Equals(value))
				{
					this.soap_idField = value;
					this.RaisePropertyChanged("soap_id");
				}
			}
		}

		public PublishingServer()
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