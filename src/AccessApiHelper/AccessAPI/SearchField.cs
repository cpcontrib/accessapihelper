using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SearchField", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SearchField : INotifyPropertyChanged
	{
		private bool IsListField;

		private string NameField;

		private SearchFieldType TypeField;

		[DataMember]
		public bool IsList
		{
			get
			{
				return this.IsListField;
			}
			set
			{
				if (!this.IsListField.Equals(value))
				{
					this.IsListField = value;
					this.RaisePropertyChanged("IsList");
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
		public SearchFieldType Type
		{
			get
			{
				return this.TypeField;
			}
			set
			{
				if (!this.TypeField.Equals(value))
				{
					this.TypeField = value;
					this.RaisePropertyChanged("Type");
				}
			}
		}

		public SearchField()
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