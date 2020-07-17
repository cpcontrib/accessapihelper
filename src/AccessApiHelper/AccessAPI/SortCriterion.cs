using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SortCriterion", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SortCriterion : INotifyPropertyChanged
	{
		private string FieldNameField;

		private bool IsDescendingField;

		private AssetPropertyNames PropertyNameField;

		[DataMember]
		public string FieldName
		{
			get
			{
				return this.FieldNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FieldNameField, value))
				{
					this.FieldNameField = value;
					this.RaisePropertyChanged("FieldName");
				}
			}
		}

		[DataMember]
		public bool IsDescending
		{
			get
			{
				return this.IsDescendingField;
			}
			set
			{
				if (!this.IsDescendingField.Equals(value))
				{
					this.IsDescendingField = value;
					this.RaisePropertyChanged("IsDescending");
				}
			}
		}

		[DataMember]
		public AssetPropertyNames PropertyName
		{
			get
			{
				return this.PropertyNameField;
			}
			set
			{
				if (!this.PropertyNameField.Equals(value))
				{
					this.PropertyNameField = value;
					this.RaisePropertyChanged("PropertyName");
				}
			}
		}

		public SortCriterion()
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