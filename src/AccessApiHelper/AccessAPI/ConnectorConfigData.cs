using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ConnectorConfigData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ConnectorConfigData : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string CollectionField;

		private int ConnectorIdField;

		private byte ConnectorTypeField;

		private string EndpointField;

		private bool IsDeletedField;

		private bool IsInsertedField;

		private bool IsModifiedField;

		private string NameField;

		private string PasswordField;

		private string ScopeField;

		private string TokenField;

		private string TokenSecretField;

		private string UsernameField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					this.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public string Collection
		{
			get
			{
				return this.CollectionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CollectionField, value))
				{
					this.CollectionField = value;
					this.RaisePropertyChanged("Collection");
				}
			}
		}

		[DataMember]
		public int ConnectorId
		{
			get
			{
				return this.ConnectorIdField;
			}
			set
			{
				if (!this.ConnectorIdField.Equals(value))
				{
					this.ConnectorIdField = value;
					this.RaisePropertyChanged("ConnectorId");
				}
			}
		}

		[DataMember]
		public byte ConnectorType
		{
			get
			{
				return this.ConnectorTypeField;
			}
			set
			{
				if (!this.ConnectorTypeField.Equals(value))
				{
					this.ConnectorTypeField = value;
					this.RaisePropertyChanged("ConnectorType");
				}
			}
		}

		[DataMember]
		public string Endpoint
		{
			get
			{
				return this.EndpointField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EndpointField, value))
				{
					this.EndpointField = value;
					this.RaisePropertyChanged("Endpoint");
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
		public string Scope
		{
			get
			{
				return this.ScopeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ScopeField, value))
				{
					this.ScopeField = value;
					this.RaisePropertyChanged("Scope");
				}
			}
		}

		[DataMember]
		public string Token
		{
			get
			{
				return this.TokenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TokenField, value))
				{
					this.TokenField = value;
					this.RaisePropertyChanged("Token");
				}
			}
		}

		[DataMember]
		public string TokenSecret
		{
			get
			{
				return this.TokenSecretField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TokenSecretField, value))
				{
					this.TokenSecretField = value;
					this.RaisePropertyChanged("TokenSecret");
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

		public ConnectorConfigData()
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