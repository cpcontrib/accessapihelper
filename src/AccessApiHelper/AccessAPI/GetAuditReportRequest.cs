using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAuditReportRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAuditReportRequest : INotifyPropertyChanged
	{
		private int ActionIdField;

		private int AssetIdField;

		private int CurrentPageField;

		private DateTime? EndDateField;

		private int FileCountField;

		private int KBytesField;

		private string LabelField;

		private SortHeaderOptionData SortOptionsField;

		private DateTime? StartDateField;

		private int UserIdField;

		[DataMember]
		public int ActionId
		{
			get
			{
				return this.ActionIdField;
			}
			set
			{
				if (!this.ActionIdField.Equals(value))
				{
					this.ActionIdField = value;
					this.RaisePropertyChanged("ActionId");
				}
			}
		}

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
		public int CurrentPage
		{
			get
			{
				return this.CurrentPageField;
			}
			set
			{
				if (!this.CurrentPageField.Equals(value))
				{
					this.CurrentPageField = value;
					this.RaisePropertyChanged("CurrentPage");
				}
			}
		}

		[DataMember]
		public DateTime? EndDate
		{
			get
			{
				return this.EndDateField;
			}
			set
			{
				if (!this.EndDateField.Equals(value))
				{
					this.EndDateField = value;
					this.RaisePropertyChanged("EndDate");
				}
			}
		}

		[DataMember]
		public int FileCount
		{
			get
			{
				return this.FileCountField;
			}
			set
			{
				if (!this.FileCountField.Equals(value))
				{
					this.FileCountField = value;
					this.RaisePropertyChanged("FileCount");
				}
			}
		}

		[DataMember]
		public int KBytes
		{
			get
			{
				return this.KBytesField;
			}
			set
			{
				if (!this.KBytesField.Equals(value))
				{
					this.KBytesField = value;
					this.RaisePropertyChanged("KBytes");
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
		public SortHeaderOptionData SortOptions
		{
			get
			{
				return this.SortOptionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SortOptionsField, value))
				{
					this.SortOptionsField = value;
					this.RaisePropertyChanged("SortOptions");
				}
			}
		}

		[DataMember]
		public DateTime? StartDate
		{
			get
			{
				return this.StartDateField;
			}
			set
			{
				if (!this.StartDateField.Equals(value))
				{
					this.StartDateField = value;
					this.RaisePropertyChanged("StartDate");
				}
			}
		}

		[DataMember]
		public int UserId
		{
			get
			{
				return this.UserIdField;
			}
			set
			{
				if (!this.UserIdField.Equals(value))
				{
					this.UserIdField = value;
					this.RaisePropertyChanged("UserId");
				}
			}
		}

		public GetAuditReportRequest()
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