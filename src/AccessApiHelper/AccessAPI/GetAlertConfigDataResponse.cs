using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAlertConfigDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAlertConfigDataResponse : WSResultClass
	{
		private ICollection<AlertActionType> alertsField;

		private bool inheritsAlertsField;

		private ICollection<int> workflowAlertsField;

		[DataMember]
		public ICollection<AlertActionType> alerts
		{
			get
			{
				return this.alertsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.alertsField, value))
				{
					this.alertsField = value;
					base.RaisePropertyChanged("alerts");
				}
			}
		}

		[DataMember]
		public bool inheritsAlerts
		{
			get
			{
				return this.inheritsAlertsField;
			}
			set
			{
				if (!this.inheritsAlertsField.Equals(value))
				{
					this.inheritsAlertsField = value;
					base.RaisePropertyChanged("inheritsAlerts");
				}
			}
		}

		[DataMember]
		public ICollection<int> workflowAlerts
		{
			get
			{
				return this.workflowAlertsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.workflowAlertsField, value))
				{
					this.workflowAlertsField = value;
					base.RaisePropertyChanged("workflowAlerts");
				}
			}
		}

		public GetAlertConfigDataResponse()
		{
		}
	}
}