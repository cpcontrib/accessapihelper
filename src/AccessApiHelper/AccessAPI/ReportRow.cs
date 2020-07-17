using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ReportRow", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ReportRow : INotifyPropertyChanged
	{
		private ICollection<string> ColumnsField;

		private ReportData DetailsField;

		[DataMember]
		public ICollection<string> Columns
		{
			get
			{
				return this.ColumnsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ColumnsField, value))
				{
					this.ColumnsField = value;
					this.RaisePropertyChanged("Columns");
				}
			}
		}

		[DataMember]
		public ReportData Details
		{
			get
			{
				return this.DetailsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DetailsField, value))
				{
					this.DetailsField = value;
					this.RaisePropertyChanged("Details");
				}
			}
		}

		public ReportRow()
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