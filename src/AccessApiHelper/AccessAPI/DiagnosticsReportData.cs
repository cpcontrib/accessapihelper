using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DiagnosticsReportData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DiagnosticsReportData : INotifyPropertyChanged
	{
		private string AssetIdField;

		private string CodeField;

		private int CountField;

		private string DateField;

		private string DescriptionField;

		private string SourceField;

		private string SuggestionField;

		[DataMember]
		public string AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetIdField, value))
				{
					this.AssetIdField = value;
					this.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public string Code
		{
			get
			{
				return this.CodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CodeField, value))
				{
					this.CodeField = value;
					this.RaisePropertyChanged("Code");
				}
			}
		}

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
		public string Date
		{
			get
			{
				return this.DateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DateField, value))
				{
					this.DateField = value;
					this.RaisePropertyChanged("Date");
				}
			}
		}

		[DataMember]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DescriptionField, value))
				{
					this.DescriptionField = value;
					this.RaisePropertyChanged("Description");
				}
			}
		}

		[DataMember]
		public string Source
		{
			get
			{
				return this.SourceField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SourceField, value))
				{
					this.SourceField = value;
					this.RaisePropertyChanged("Source");
				}
			}
		}

		[DataMember]
		public string Suggestion
		{
			get
			{
				return this.SuggestionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SuggestionField, value))
				{
					this.SuggestionField = value;
					this.RaisePropertyChanged("Suggestion");
				}
			}
		}

		public DiagnosticsReportData()
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