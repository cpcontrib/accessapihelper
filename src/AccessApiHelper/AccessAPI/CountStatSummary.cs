using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CountStatSummary", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model.Response")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CountStatSummary : INotifyPropertyChanged
	{
		private string CategoryField;

		private int ConversionCountField;

		private DateTime DateField;

		private string NameField;

		private int ViewCountField;

		[DataMember]
		public string Category
		{
			get
			{
				return this.CategoryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CategoryField, value))
				{
					this.CategoryField = value;
					this.RaisePropertyChanged("Category");
				}
			}
		}

		[DataMember]
		public int ConversionCount
		{
			get
			{
				return this.ConversionCountField;
			}
			set
			{
				if (!this.ConversionCountField.Equals(value))
				{
					this.ConversionCountField = value;
					this.RaisePropertyChanged("ConversionCount");
				}
			}
		}

		[DataMember]
		public DateTime Date
		{
			get
			{
				return this.DateField;
			}
			set
			{
				if (!this.DateField.Equals(value))
				{
					this.DateField = value;
					this.RaisePropertyChanged("Date");
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
		public int ViewCount
		{
			get
			{
				return this.ViewCountField;
			}
			set
			{
				if (!this.ViewCountField.Equals(value))
				{
					this.ViewCountField = value;
					this.RaisePropertyChanged("ViewCount");
				}
			}
		}

		public CountStatSummary()
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