using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RepositoryServer", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class RepositoryServer : INotifyPropertyChanged
	{
		private ICollection<PublishingServer> PublishingServersField;

		private int? asset_idField;

		private string ftp_rootField;

		private bool? group_executeField;

		private bool? group_readField;

		private bool? group_writeField;

		private string hostnameField;

		private int idField;

		private int? modeField;

		private bool? owner_executeField;

		private bool? owner_readField;

		private bool? owner_writeField;

		private string passwordField;

		private byte pw_encryptionField;

		private bool? safe_writeField;

		private byte? secure_modeField;

		private string usernameField;

		private bool? world_executeField;

		private bool? world_readField;

		private bool? world_writeField;

		[DataMember]
		public int? asset_id
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
		public string ftp_root
		{
			get
			{
				return this.ftp_rootField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ftp_rootField, value))
				{
					this.ftp_rootField = value;
					this.RaisePropertyChanged("ftp_root");
				}
			}
		}

		[DataMember]
		public bool? group_execute
		{
			get
			{
				return this.group_executeField;
			}
			set
			{
				if (!this.group_executeField.Equals(value))
				{
					this.group_executeField = value;
					this.RaisePropertyChanged("group_execute");
				}
			}
		}

		[DataMember]
		public bool? group_read
		{
			get
			{
				return this.group_readField;
			}
			set
			{
				if (!this.group_readField.Equals(value))
				{
					this.group_readField = value;
					this.RaisePropertyChanged("group_read");
				}
			}
		}

		[DataMember]
		public bool? group_write
		{
			get
			{
				return this.group_writeField;
			}
			set
			{
				if (!this.group_writeField.Equals(value))
				{
					this.group_writeField = value;
					this.RaisePropertyChanged("group_write");
				}
			}
		}

		[DataMember]
		public string hostname
		{
			get
			{
				return this.hostnameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.hostnameField, value))
				{
					this.hostnameField = value;
					this.RaisePropertyChanged("hostname");
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
		public int? mode
		{
			get
			{
				return this.modeField;
			}
			set
			{
				if (!this.modeField.Equals(value))
				{
					this.modeField = value;
					this.RaisePropertyChanged("mode");
				}
			}
		}

		[DataMember]
		public bool? owner_execute
		{
			get
			{
				return this.owner_executeField;
			}
			set
			{
				if (!this.owner_executeField.Equals(value))
				{
					this.owner_executeField = value;
					this.RaisePropertyChanged("owner_execute");
				}
			}
		}

		[DataMember]
		public bool? owner_read
		{
			get
			{
				return this.owner_readField;
			}
			set
			{
				if (!this.owner_readField.Equals(value))
				{
					this.owner_readField = value;
					this.RaisePropertyChanged("owner_read");
				}
			}
		}

		[DataMember]
		public bool? owner_write
		{
			get
			{
				return this.owner_writeField;
			}
			set
			{
				if (!this.owner_writeField.Equals(value))
				{
					this.owner_writeField = value;
					this.RaisePropertyChanged("owner_write");
				}
			}
		}

		[DataMember]
		public string password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				if (!object.ReferenceEquals(this.passwordField, value))
				{
					this.passwordField = value;
					this.RaisePropertyChanged("password");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingServer> PublishingServers
		{
			get
			{
				return this.PublishingServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PublishingServersField, value))
				{
					this.PublishingServersField = value;
					this.RaisePropertyChanged("PublishingServers");
				}
			}
		}

		[DataMember]
		public byte pw_encryption
		{
			get
			{
				return this.pw_encryptionField;
			}
			set
			{
				if (!this.pw_encryptionField.Equals(value))
				{
					this.pw_encryptionField = value;
					this.RaisePropertyChanged("pw_encryption");
				}
			}
		}

		[DataMember]
		public bool? safe_write
		{
			get
			{
				return this.safe_writeField;
			}
			set
			{
				if (!this.safe_writeField.Equals(value))
				{
					this.safe_writeField = value;
					this.RaisePropertyChanged("safe_write");
				}
			}
		}

		[DataMember]
		public byte? secure_mode
		{
			get
			{
				return this.secure_modeField;
			}
			set
			{
				if (!this.secure_modeField.Equals(value))
				{
					this.secure_modeField = value;
					this.RaisePropertyChanged("secure_mode");
				}
			}
		}

		[DataMember]
		public string username
		{
			get
			{
				return this.usernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.usernameField, value))
				{
					this.usernameField = value;
					this.RaisePropertyChanged("username");
				}
			}
		}

		[DataMember]
		public bool? world_execute
		{
			get
			{
				return this.world_executeField;
			}
			set
			{
				if (!this.world_executeField.Equals(value))
				{
					this.world_executeField = value;
					this.RaisePropertyChanged("world_execute");
				}
			}
		}

		[DataMember]
		public bool? world_read
		{
			get
			{
				return this.world_readField;
			}
			set
			{
				if (!this.world_readField.Equals(value))
				{
					this.world_readField = value;
					this.RaisePropertyChanged("world_read");
				}
			}
		}

		[DataMember]
		public bool? world_write
		{
			get
			{
				return this.world_writeField;
			}
			set
			{
				if (!this.world_writeField.Equals(value))
				{
					this.world_writeField = value;
					this.RaisePropertyChanged("world_write");
				}
			}
		}

		public RepositoryServer()
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