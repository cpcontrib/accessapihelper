using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ReportData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ReportData : INotifyPropertyChanged
	{
		private ICollection<string> HeadingsField;

		private ICollection<ReportRow> RowsField;

		[DataMember]
		public ICollection<string> Headings
		{
			get
			{
				return this.HeadingsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HeadingsField, value))
				{
					this.HeadingsField = value;
					this.RaisePropertyChanged("Headings");
				}
			}
		}

		[DataMember]
		public ICollection<ReportRow> Rows
		{
			get
			{
				return this.RowsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RowsField, value))
				{
					this.RowsField = value;
					this.RaisePropertyChanged("Rows");
				}
			}
		}

		public ReportData()
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