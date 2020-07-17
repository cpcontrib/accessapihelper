using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UserLoginReportData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UserLoginReportData : INotifyPropertyChanged
	{
		private int actionsField;

		private DateTime created_dateField;

		private DateTime dateField;

		private string emailField;

		private string fromField;

		private string nameField;

		private string phoneField;

		private string priorityField;

		private string reasonField;

		private int user_idField;

		[DataMember]
		public int actions
		{
			get
			{
				return this.actionsField;
			}
			set
			{
				if (!this.actionsField.Equals(value))
				{
					this.actionsField = value;
					this.RaisePropertyChanged("actions");
				}
			}
		}

		[DataMember]
		public DateTime created_date
		{
			get
			{
				return this.created_dateField;
			}
			set
			{
				if (!this.created_dateField.Equals(value))
				{
					this.created_dateField = value;
					this.RaisePropertyChanged("created_date");
				}
			}
		}

		[DataMember]
		public DateTime date
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
		public string email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.emailField, value))
				{
					this.emailField = value;
					this.RaisePropertyChanged("email");
				}
			}
		}

		[DataMember]
		public string @from
		{
			get
			{
				return this.fromField;
			}
			set
			{
				if (!object.ReferenceEquals(this.fromField, value))
				{
					this.fromField = value;
					this.RaisePropertyChanged("from");
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
		public string phone
		{
			get
			{
				return this.phoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.phoneField, value))
				{
					this.phoneField = value;
					this.RaisePropertyChanged("phone");
				}
			}
		}

		[DataMember]
		public string priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				if (!object.ReferenceEquals(this.priorityField, value))
				{
					this.priorityField = value;
					this.RaisePropertyChanged("priority");
				}
			}
		}

		[DataMember]
		public string reason
		{
			get
			{
				return this.reasonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.reasonField, value))
				{
					this.reasonField = value;
					this.RaisePropertyChanged("reason");
				}
			}
		}

		[DataMember]
		public int user_id
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

		public UserLoginReportData()
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