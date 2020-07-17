using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SoapServerData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SoapServerData : INotifyPropertyChanged
	{
		private string CookieField;

		private string HttpPasswordField;

		private string HttpUsernameField;

		private int IdField;

		private bool IsDeletedField;

		private bool IsInsertedField;

		private bool IsModifiedField;

		private byte MethodField;

		private string NameField;

		private byte ResultField;

		private int TimeoutField;

		private string UrlField;

		[DataMember]
		public string Cookie
		{
			get
			{
				return this.CookieField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CookieField, value))
				{
					this.CookieField = value;
					this.RaisePropertyChanged("Cookie");
				}
			}
		}

		[DataMember]
		public string HttpPassword
		{
			get
			{
				return this.HttpPasswordField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HttpPasswordField, value))
				{
					this.HttpPasswordField = value;
					this.RaisePropertyChanged("HttpPassword");
				}
			}
		}

		[DataMember]
		public string HttpUsername
		{
			get
			{
				return this.HttpUsernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HttpUsernameField, value))
				{
					this.HttpUsernameField = value;
					this.RaisePropertyChanged("HttpUsername");
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
		public byte Method
		{
			get
			{
				return this.MethodField;
			}
			set
			{
				if (!this.MethodField.Equals(value))
				{
					this.MethodField = value;
					this.RaisePropertyChanged("Method");
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
		public byte Result
		{
			get
			{
				return this.ResultField;
			}
			set
			{
				if (!this.ResultField.Equals(value))
				{
					this.ResultField = value;
					this.RaisePropertyChanged("Result");
				}
			}
		}

		[DataMember]
		public int Timeout
		{
			get
			{
				return this.TimeoutField;
			}
			set
			{
				if (!this.TimeoutField.Equals(value))
				{
					this.TimeoutField = value;
					this.RaisePropertyChanged("Timeout");
				}
			}
		}

		[DataMember]
		public string Url
		{
			get
			{
				return this.UrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UrlField, value))
				{
					this.UrlField = value;
					this.RaisePropertyChanged("Url");
				}
			}
		}

		public SoapServerData()
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