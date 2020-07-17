using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetScheduleResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetScheduleResponse : WSResultClass
	{
		private ICollection<cpTimeZoneInfo> TimezonesField;

		private WorklistAsset assetField;

		private ScheduleData assetScheduleField;

		private ICollection<AssetWorkflowSchedule> assetWorkflowSchedulesField;

		[DataMember]
		public WorklistAsset asset
		{
			get
			{
				return this.assetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetField, value))
				{
					this.assetField = value;
					base.RaisePropertyChanged("asset");
				}
			}
		}

		[DataMember]
		public ScheduleData assetSchedule
		{
			get
			{
				return this.assetScheduleField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetScheduleField, value))
				{
					this.assetScheduleField = value;
					base.RaisePropertyChanged("assetSchedule");
				}
			}
		}

		[DataMember]
		public ICollection<AssetWorkflowSchedule> assetWorkflowSchedules
		{
			get
			{
				return this.assetWorkflowSchedulesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetWorkflowSchedulesField, value))
				{
					this.assetWorkflowSchedulesField = value;
					base.RaisePropertyChanged("assetWorkflowSchedules");
				}
			}
		}

		[DataMember]
		public ICollection<cpTimeZoneInfo> Timezones
		{
			get
			{
				return this.TimezonesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimezonesField, value))
				{
					this.TimezonesField = value;
					base.RaisePropertyChanged("Timezones");
				}
			}
		}

		public GetAssetScheduleResponse()
		{
		}
	}
}