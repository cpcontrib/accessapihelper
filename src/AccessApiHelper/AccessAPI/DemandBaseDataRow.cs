using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DemandBaseDataRow", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DemandBaseDataRow : INotifyPropertyChanged
	{
		private string CompanyNameField;

		private string CompanySizeField;

		private string CountryField;

		private int PageViewsField;

		private string StateField;

		private int VisitsField;

		[DataMember]
		public string CompanyName
		{
			get
			{
				return this.CompanyNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CompanyNameField, value))
				{
					this.CompanyNameField = value;
					this.RaisePropertyChanged("CompanyName");
				}
			}
		}

		[DataMember]
		public string CompanySize
		{
			get
			{
				return this.CompanySizeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CompanySizeField, value))
				{
					this.CompanySizeField = value;
					this.RaisePropertyChanged("CompanySize");
				}
			}
		}

		[DataMember]
		public string Country
		{
			get
			{
				return this.CountryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CountryField, value))
				{
					this.CountryField = value;
					this.RaisePropertyChanged("Country");
				}
			}
		}

		[DataMember]
		public int PageViews
		{
			get
			{
				return this.PageViewsField;
			}
			set
			{
				if (!this.PageViewsField.Equals(value))
				{
					this.PageViewsField = value;
					this.RaisePropertyChanged("PageViews");
				}
			}
		}

		[DataMember]
		public string State
		{
			get
			{
				return this.StateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StateField, value))
				{
					this.StateField = value;
					this.RaisePropertyChanged("State");
				}
			}
		}

		[DataMember]
		public int Visits
		{
			get
			{
				return this.VisitsField;
			}
			set
			{
				if (!this.VisitsField.Equals(value))
				{
					this.VisitsField = value;
					this.RaisePropertyChanged("Visits");
				}
			}
		}

		public DemandBaseDataRow()
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