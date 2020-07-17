using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetAlertConfigDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetAlertConfigDataRequest : INotifyPropertyChanged
	{
		private ICollection<AlertActionType> alertsField;

		private int assetIdField;

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
					this.RaisePropertyChanged("alerts");
				}
			}
		}

		[DataMember]
		public int assetId
		{
			get
			{
				return this.assetIdField;
			}
			set
			{
				if (!this.assetIdField.Equals(value))
				{
					this.assetIdField = value;
					this.RaisePropertyChanged("assetId");
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
					this.RaisePropertyChanged("inheritsAlerts");
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
					this.RaisePropertyChanged("workflowAlerts");
				}
			}
		}

		public SetAlertConfigDataRequest()
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