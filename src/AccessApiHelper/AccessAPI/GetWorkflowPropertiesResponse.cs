using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetWorkflowPropertiesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetWorkflowPropertiesResponse : WSResultClass
	{
		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		private int WorkflowIdField;

		private ICollection<WorkflowListItem> WorkflowListField;

		[DataMember]
		public ICollection<cpListscpKeyValuePair> UIConfiguration
		{
			get
			{
				return this.UIConfigurationField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UIConfigurationField, value))
				{
					this.UIConfigurationField = value;
					base.RaisePropertyChanged("UIConfiguration");
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
					base.RaisePropertyChanged("WorkflowId");
				}
			}
		}

		[DataMember]
		public ICollection<WorkflowListItem> WorkflowList
		{
			get
			{
				return this.WorkflowListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowListField, value))
				{
					this.WorkflowListField = value;
					base.RaisePropertyChanged("WorkflowList");
				}
			}
		}

		public GetWorkflowPropertiesResponse()
		{
		}
	}
}