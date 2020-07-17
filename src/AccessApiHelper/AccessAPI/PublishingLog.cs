using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingLog", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingLog : INotifyPropertyChanged
	{
		private byte? actionField;

		private int asset_idField;

		private DateTime? dateField;

		private string db_server_nameField;

		private string filenameField;

		private string hashField;

		private int idField;

		private string package_nameField;

		private byte? post_reasonField;

		private string pub_host_nameField;

		private int publishing_server_idField;

		private byte? reasonField;

		private int? secondsField;

		private int? session_idField;

		private int? sizeField;

		private byte? subreasonField;

		private string textField;

		[DataMember]
		public byte? action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				if (!this.actionField.Equals(value))
				{
					this.actionField = value;
					this.RaisePropertyChanged("action");
				}
			}
		}

		[DataMember]
		public int asset_id
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
		public DateTime? date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				if (!this.dateField.Equals(value))
				{
					this.dateField = value;
					this.RaisePropertyChanged("date");
				}
			}
		}

		[DataMember]
		public string db_server_name
		{
			get
			{
				return this.db_server_nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.db_server_nameField, value))
				{
					this.db_server_nameField = value;
					this.RaisePropertyChanged("db_server_name");
				}
			}
		}

		[DataMember]
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.filenameField, value))
				{
					this.filenameField = value;
					this.RaisePropertyChanged("filename");
				}
			}
		}

		[DataMember]
		public string hash
		{
			get
			{
				return this.hashField;
			}
			set
			{
				if (!object.ReferenceEquals(this.hashField, value))
				{
					this.hashField = value;
					this.RaisePropertyChanged("hash");
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
		public string package_name
		{
			get
			{
				return this.package_nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.package_nameField, value))
				{
					this.package_nameField = value;
					this.RaisePropertyChanged("package_name");
				}
			}
		}

		[DataMember]
		public byte? post_reason
		{
			get
			{
				return this.post_reasonField;
			}
			set
			{
				if (!this.post_reasonField.Equals(value))
				{
					this.post_reasonField = value;
					this.RaisePropertyChanged("post_reason");
				}
			}
		}

		[DataMember]
		public string pub_host_name
		{
			get
			{
				return this.pub_host_nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.pub_host_nameField, value))
				{
					this.pub_host_nameField = value;
					this.RaisePropertyChanged("pub_host_name");
				}
			}
		}

		[DataMember]
		public int publishing_server_id
		{
			get
			{
				return this.publishing_server_idField;
			}
			set
			{
				if (!this.publishing_server_idField.Equals(value))
				{
					this.publishing_server_idField = value;
					this.RaisePropertyChanged("publishing_server_id");
				}
			}
		}

		[DataMember]
		public byte? reason
		{
			get
			{
				return this.reasonField;
			}
			set
			{
				if (!this.reasonField.Equals(value))
				{
					this.reasonField = value;
					this.RaisePropertyChanged("reason");
				}
			}
		}

		[DataMember]
		public int? seconds
		{
			get
			{
				return this.secondsField;
			}
			set
			{
				if (!this.secondsField.Equals(value))
				{
					this.secondsField = value;
					this.RaisePropertyChanged("seconds");
				}
			}
		}

		[DataMember]
		public int? session_id
		{
			get
			{
				return this.session_idField;
			}
			set
			{
				if (!this.session_idField.Equals(value))
				{
					this.session_idField = value;
					this.RaisePropertyChanged("session_id");
				}
			}
		}

		[DataMember]
		public int? size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				if (!this.sizeField.Equals(value))
				{
					this.sizeField = value;
					this.RaisePropertyChanged("size");
				}
			}
		}

		[DataMember]
		public byte? subreason
		{
			get
			{
				return this.subreasonField;
			}
			set
			{
				if (!this.subreasonField.Equals(value))
				{
					this.subreasonField = value;
					this.RaisePropertyChanged("subreason");
				}
			}
		}

		[DataMember]
		public string text
		{
			get
			{
				return this.textField;
			}
			set
			{
				if (!object.ReferenceEquals(this.textField, value))
				{
					this.textField = value;
					this.RaisePropertyChanged("text");
				}
			}
		}

		public PublishingLog()
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