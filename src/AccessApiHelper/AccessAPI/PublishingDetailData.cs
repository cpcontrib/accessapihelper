using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingDetailData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingDetailData : INotifyPropertyChanged
	{
		private string ActionField;

		private int AssetIdField;

		private string FileNameField;

		private int IdField;

		private string ResultMessageField;

		private int SizeField;

		private DateTime StartDateField;

		private int TimeTakenField;

		[DataMember]
		public string Action
		{
			get
			{
				return this.ActionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActionField, value))
				{
					this.ActionField = value;
					this.RaisePropertyChanged("Action");
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
		public string FileName
		{
			get
			{
				return this.FileNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FileNameField, value))
				{
					this.FileNameField = value;
					this.RaisePropertyChanged("FileName");
				}
			}
		}

		[DataMember]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember]
		public string ResultMessage
		{
			get
			{
				return this.ResultMessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ResultMessageField, value))
				{
					this.ResultMessageField = value;
					this.RaisePropertyChanged("ResultMessage");
				}
			}
		}

		[DataMember]
		public int Size
		{
			get
			{
				return this.SizeField;
			}
			set
			{
				if (!this.SizeField.Equals(value))
				{
					this.SizeField = value;
					this.RaisePropertyChanged("Size");
				}
			}
		}

		[DataMember]
		public DateTime StartDate
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
		public int TimeTaken
		{
			get
			{
				return this.TimeTakenField;
			}
			set
			{
				if (!this.TimeTakenField.Equals(value))
				{
					this.TimeTakenField = value;
					this.RaisePropertyChanged("TimeTaken");
				}
			}
		}

		public PublishingDetailData()
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