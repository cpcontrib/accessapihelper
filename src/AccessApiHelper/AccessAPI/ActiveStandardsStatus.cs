using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ActiveStandardsStatus", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ActiveStandardsStatus : INotifyPropertyChanged
	{
		private string assetIdField;

		private ICollection<ActiveStandardsCheckpoint> checkpointsField;

		private string createdField;

		private string siteNameField;

		private string totalCheckpointsField;

		private string totalErrorsField;

		private string urlField;

		[DataMember]
		public string assetId
		{
			get
			{
				return this.assetIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetIdField, value))
				{
					this.assetIdField = value;
					this.RaisePropertyChanged("assetId");
				}
			}
		}

		[DataMember]
		public ICollection<ActiveStandardsCheckpoint> checkpoints
		{
			get
			{
				return this.checkpointsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.checkpointsField, value))
				{
					this.checkpointsField = value;
					this.RaisePropertyChanged("checkpoints");
				}
			}
		}

		[DataMember]
		public string created
		{
			get
			{
				return this.createdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.createdField, value))
				{
					this.createdField = value;
					this.RaisePropertyChanged("created");
				}
			}
		}

		[DataMember]
		public string siteName
		{
			get
			{
				return this.siteNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.siteNameField, value))
				{
					this.siteNameField = value;
					this.RaisePropertyChanged("siteName");
				}
			}
		}

		[DataMember]
		public string totalCheckpoints
		{
			get
			{
				return this.totalCheckpointsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.totalCheckpointsField, value))
				{
					this.totalCheckpointsField = value;
					this.RaisePropertyChanged("totalCheckpoints");
				}
			}
		}

		[DataMember]
		public string totalErrors
		{
			get
			{
				return this.totalErrorsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.totalErrorsField, value))
				{
					this.totalErrorsField = value;
					this.RaisePropertyChanged("totalErrors");
				}
			}
		}

		[DataMember]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.urlField, value))
				{
					this.urlField = value;
					this.RaisePropertyChanged("url");
				}
			}
		}

		public ActiveStandardsStatus()
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