using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="JobQueue", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class JobQueue : INotifyPropertyChanged
	{
		private int? asset_idField;

		private DateTime? dateField;

		private string db_server_nameField;

		private int idField;

		private int job_idField;

		private int? job_typeField;

		private string request_payloadField;

		private int? result_codeField;

		private string server_host_nameField;

		private byte stateField;

		private DateTime? state_changedField;

		private int? statusField;

		private int? user_idField;

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
		public int job_id
		{
			get
			{
				return this.job_idField;
			}
			set
			{
				if (!this.job_idField.Equals(value))
				{
					this.job_idField = value;
					this.RaisePropertyChanged("job_id");
				}
			}
		}

		[DataMember]
		public int? job_type
		{
			get
			{
				return this.job_typeField;
			}
			set
			{
				if (!this.job_typeField.Equals(value))
				{
					this.job_typeField = value;
					this.RaisePropertyChanged("job_type");
				}
			}
		}

		[DataMember]
		public string request_payload
		{
			get
			{
				return this.request_payloadField;
			}
			set
			{
				if (!object.ReferenceEquals(this.request_payloadField, value))
				{
					this.request_payloadField = value;
					this.RaisePropertyChanged("request_payload");
				}
			}
		}

		[DataMember]
		public int? result_code
		{
			get
			{
				return this.result_codeField;
			}
			set
			{
				if (!this.result_codeField.Equals(value))
				{
					this.result_codeField = value;
					this.RaisePropertyChanged("result_code");
				}
			}
		}

		[DataMember]
		public string server_host_name
		{
			get
			{
				return this.server_host_nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.server_host_nameField, value))
				{
					this.server_host_nameField = value;
					this.RaisePropertyChanged("server_host_name");
				}
			}
		}

		[DataMember]
		public byte state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				if (!this.stateField.Equals(value))
				{
					this.stateField = value;
					this.RaisePropertyChanged("state");
				}
			}
		}

		[DataMember]
		public DateTime? state_changed
		{
			get
			{
				return this.state_changedField;
			}
			set
			{
				if (!this.state_changedField.Equals(value))
				{
					this.state_changedField = value;
					this.RaisePropertyChanged("state_changed");
				}
			}
		}

		[DataMember]
		public int? status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				if (!this.statusField.Equals(value))
				{
					this.statusField = value;
					this.RaisePropertyChanged("status");
				}
			}
		}

		[DataMember]
		public int? user_id
		{
			get
			{
				return this.user_idField;
			}
			set
			{
				if (!this.user_idField.Equals(value))
				{
					this.user_idField = value;
					this.RaisePropertyChanged("user_id");
				}
			}
		}

		public JobQueue()
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