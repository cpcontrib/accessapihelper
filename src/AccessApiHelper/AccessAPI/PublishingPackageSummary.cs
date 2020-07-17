using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingPackageSummary", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingPackageSummary : INotifyPropertyChanged
	{
		private int AffectedAssetCountField;

		private int AffectedDeploymentDefinitionsField;

		private ICollection<int> AffectedStatusListField;

		private int AffectedWorkflowCountField;

		private int PublishingServerIdField;

		private TimeSpan TimeToCalculateAssetCountField;

		[DataMember]
		public int AffectedAssetCount
		{
			get
			{
				return this.AffectedAssetCountField;
			}
			set
			{
				if (!this.AffectedAssetCountField.Equals(value))
				{
					this.AffectedAssetCountField = value;
					this.RaisePropertyChanged("AffectedAssetCount");
				}
			}
		}

		[DataMember]
		public int AffectedDeploymentDefinitions
		{
			get
			{
				return this.AffectedDeploymentDefinitionsField;
			}
			set
			{
				if (!this.AffectedDeploymentDefinitionsField.Equals(value))
				{
					this.AffectedDeploymentDefinitionsField = value;
					this.RaisePropertyChanged("AffectedDeploymentDefinitions");
				}
			}
		}

		[DataMember]
		public ICollection<int> AffectedStatusList
		{
			get
			{
				return this.AffectedStatusListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AffectedStatusListField, value))
				{
					this.AffectedStatusListField = value;
					this.RaisePropertyChanged("AffectedStatusList");
				}
			}
		}

		[DataMember]
		public int AffectedWorkflowCount
		{
			get
			{
				return this.AffectedWorkflowCountField;
			}
			set
			{
				if (!this.AffectedWorkflowCountField.Equals(value))
				{
					this.AffectedWorkflowCountField = value;
					this.RaisePropertyChanged("AffectedWorkflowCount");
				}
			}
		}

		[DataMember]
		public int PublishingServerId
		{
			get
			{
				return this.PublishingServerIdField;
			}
			set
			{
				if (!this.PublishingServerIdField.Equals(value))
				{
					this.PublishingServerIdField = value;
					this.RaisePropertyChanged("PublishingServerId");
				}
			}
		}

		[DataMember]
		public TimeSpan TimeToCalculateAssetCount
		{
			get
			{
				return this.TimeToCalculateAssetCountField;
			}
			set
			{
				if (!this.TimeToCalculateAssetCountField.Equals(value))
				{
					this.TimeToCalculateAssetCountField = value;
					this.RaisePropertyChanged("TimeToCalculateAssetCount");
				}
			}
		}

		public PublishingPackageSummary()
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