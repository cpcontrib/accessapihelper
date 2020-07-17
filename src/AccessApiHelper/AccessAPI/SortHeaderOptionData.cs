using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SortHeaderOptionData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SortHeaderOptionData : INotifyPropertyChanged
	{
		private bool IsAscendingField;

		private string SortOptionField;

		[DataMember]
		public bool IsAscending
		{
			get
			{
				return this.IsAscendingField;
			}
			set
			{
				if (!this.IsAscendingField.Equals(value))
				{
					this.IsAscendingField = value;
					this.RaisePropertyChanged("IsAscending");
				}
			}
		}

		[DataMember]
		public string SortOption
		{
			get
			{
				return this.SortOptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SortOptionField, value))
				{
					this.SortOptionField = value;
					this.RaisePropertyChanged("SortOption");
				}
			}
		}

		public SortHeaderOptionData()
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