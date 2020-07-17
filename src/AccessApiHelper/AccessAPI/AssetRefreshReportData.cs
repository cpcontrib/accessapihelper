using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetRefreshReportData", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetRefreshReportData : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string FrequencyField;

		private string LabelField;

		private DateTime NextRefreshField;

		private string PathField;

		private int WorkflowIdField;

		private int WorkflowStatusField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					this.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public string Frequency
		{
			get
			{
				return this.FrequencyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FrequencyField, value))
				{
					this.FrequencyField = value;
					this.RaisePropertyChanged("Frequency");
				}
			}
		}

		[DataMember]
		public string Label
		{
			get
			{
				return this.LabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LabelField, value))
				{
					this.LabelField = value;
					this.RaisePropertyChanged("Label");
				}
			}
		}

		[DataMember]
		public DateTime NextRefresh
		{
			get
			{
				return this.NextRefreshField;
			}
			set
			{
				if (!this.NextRefreshField.Equals(value))
				{
					this.NextRefreshField = value;
					this.RaisePropertyChanged("NextRefresh");
				}
			}
		}

		[DataMember]
		public string Path
		{
			get
			{
				return this.PathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PathField, value))
				{
					this.PathField = value;
					this.RaisePropertyChanged("Path");
				}
			}
		}

		[DataMember]
		public int WorkflowId
		{
			get
			{
				return this.WorkflowIdField;
			}
			set
			{
				if (!this.WorkflowIdField.Equals(value))
				{
					this.WorkflowIdField = value;
					this.RaisePropertyChanged("WorkflowId");
				}
			}
		}

		[DataMember]
		public int WorkflowStatus
		{
			get
			{
				return this.WorkflowStatusField;
			}
			set
			{
				if (!this.WorkflowStatusField.Equals(value))
				{
					this.WorkflowStatusField = value;
					this.RaisePropertyChanged("WorkflowStatus");
				}
			}
		}

		public AssetRefreshReportData()
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