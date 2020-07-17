using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetUserPreferenceDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetUserPreferenceDataRequest : INotifyPropertyChanged
	{
		private int IdField;

		private Dictionary<PreferenceDataType, string> PreferenceFieldsField;

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

		public SetUserPreferenceDataRequest()
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