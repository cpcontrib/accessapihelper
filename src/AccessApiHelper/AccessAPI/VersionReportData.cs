using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="VersionReportData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class VersionReportData : INotifyPropertyChanged
	{
		private int AssetIdField;

		private int? ChangeField;

		private string CommentField;

		private string LabelField;

		private DateTime Modified_OnField;

		private string NameField;

		private int StatusIdField;

		private int VersionIdField;

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
		public int? Change
		{
			get
			{
				return this.ChangeField;
			}
			set
			{
				if (!this.ChangeField.Equals(value))
				{
					this.ChangeField = value;
					this.RaisePropertyChanged("Change");
				}
			}
		}

		[DataMember]
		public string Comment
		{
			get
			{
				return this.CommentField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CommentField, value))
				{
					this.CommentField = value;
					this.RaisePropertyChanged("Comment");
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
		public DateTime Modified_On
		{
			get
			{
				return this.Modified_OnField;
			}
			set
			{
				if (!this.Modified_OnField.Equals(value))
				{
					this.Modified_OnField = value;
					this.RaisePropertyChanged("Modified_On");
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
		public int StatusId
		{
			get
			{
				return this.StatusIdField;
			}
			set
			{
				if (!this.StatusIdField.Equals(value))
				{
					this.StatusIdField = value;
					this.RaisePropertyChanged("StatusId");
				}
			}
		}

		[DataMember]
		public int VersionId
		{
			get
			{
				return this.VersionIdField;
			}
			set
			{
				if (!this.VersionIdField.Equals(value))
				{
					this.VersionIdField = value;
					this.RaisePropertyChanged("VersionId");
				}
			}
		}

		public VersionReportData()
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