using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetUserDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetUserDataRequest : INotifyPropertyChanged
	{
		private bool GenerateOneTimeUsePasswordField;

		private int IdField;

		private Dictionary<PreferenceDataType, string> PreferenceFieldsField;

		private Dictionary<UserDataType, string> UserFieldsField;

		private Dictionary<string, string> UserGroupFieldsField;

		[DataMember]
		public bool GenerateOneTimeUsePassword
		{
			get
			{
				return this.GenerateOneTimeUsePasswordField;
			}
			set
			{
				if (!this.GenerateOneTimeUsePasswordField.Equals(value))
				{
					this.GenerateOneTimeUsePasswordField = value;
					this.RaisePropertyChanged("GenerateOneTimeUsePassword");
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
		public Dictionary<PreferenceDataType, string> PreferenceFields
		{
			get
			{
				return this.PreferenceFieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PreferenceFieldsField, value))
				{
					this.PreferenceFieldsField = value;
					this.RaisePropertyChanged("PreferenceFields");
				}
			}
		}

		[DataMember]
		public Dictionary<UserDataType, string> UserFields
		{
			get
			{
				return this.UserFieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserFieldsField, value))
				{
					this.UserFieldsField = value;
					this.RaisePropertyChanged("UserFields");
				}
			}
		}

		[DataMember]
		public Dictionary<string, string> UserGroupFields
		{
			get
			{
				return this.UserGroupFieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserGroupFieldsField, value))
				{
					this.UserGroupFieldsField = value;
					this.RaisePropertyChanged("UserGroupFields");
				}
			}
		}

		public SetUserDataRequest()
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