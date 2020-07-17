using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpKVPOfSearchFieldTypeArrayOfComparisonv_SQRvoIg", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class cpKVPOfSearchFieldTypeArrayOfComparisonv_SQRvoIg : INotifyPropertyChanged
	{
		private SearchFieldType KeyField;

		private ICollection<Comparison> ValueField;

		[DataMember]
		public SearchFieldType Key
		{
			get
			{
				return this.KeyField;
			}
			set
			{
				if (!this.KeyField.Equals(value))
				{
					this.KeyField = value;
					this.RaisePropertyChanged("Key");
				}
			}
		}

		[DataMember]
		public ICollection<Comparison> Value
		{
			get
			{
				return this.ValueField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ValueField, value))
				{
					this.ValueField = value;
					this.RaisePropertyChanged("Value");
				}
			}
		}

		public cpKVPOfSearchFieldTypeArrayOfComparisonv_SQRvoIg()
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