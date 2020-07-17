using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishedPageData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishedPageData : INotifyPropertyChanged
	{
		private int CountField;

		private string NameField;

		private string ReportURIField;

		[DataMember]
		public int Count
		{
			get
			{
				return this.CountField;
			}
			set
			{
				if (!this.CountField.Equals(value))
				{
					this.CountField = value;
					this.RaisePropertyChanged("Count");
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
		public string ReportURI
		{
			get
			{
				return this.ReportURIField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ReportURIField, value))
				{
					this.ReportURIField = value;
					this.RaisePropertyChanged("ReportURI");
				}
			}
		}

		public PublishedPageData()
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