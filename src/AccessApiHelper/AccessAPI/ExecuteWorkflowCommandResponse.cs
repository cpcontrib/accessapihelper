using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ExecuteWorkflowCommandResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ExecuteWorkflowCommandResponse : WSResultClass
	{
		private int PublishingSessionIdField;

		private cpWorkflowActionRequired RequiredActionField;

		private WorklistAsset assetField;

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
		public int PublishingSessionId
		{
			get
			{
				return this.PublishingSessionIdField;
			}
			set
			{
				if (!this.PublishingSessionIdField.Equals(value))
				{
					this.PublishingSessionIdField = value;
					base.RaisePropertyChanged("PublishingSessionId");
				}
			}
		}

		[DataMember]
		public cpWorkflowActionRequired RequiredAction
		{
			get
			{
				return this.RequiredActionField;
			}
			set
			{
				if (!this.RequiredActionField.Equals(value))
				{
					this.RequiredActionField = value;
					base.RaisePropertyChanged("RequiredAction");
				}
			}
		}

		public ExecuteWorkflowCommandResponse()
		{
		}
	}
}