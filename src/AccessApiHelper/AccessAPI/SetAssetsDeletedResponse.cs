using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetAssetsDeletedResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetAssetsDeletedResponse : WSResultClass
	{
		private bool IsLongRunningField;

		private int JobIdField;

		private Dictionary<int, SetAssetDeletedResponse> ResponseListField;

		[DataMember]
		public bool IsLongRunning
		{
			get
			{
				return this.IsLongRunningField;
			}
			set
			{
				if (!this.IsLongRunningField.Equals(value))
				{
					this.IsLongRunningField = value;
					base.RaisePropertyChanged("IsLongRunning");
				}
			}
		}

		[DataMember]
		public int JobId
		{
			get
			{
				return this.JobIdField;
			}
			set
			{
				if (!this.JobIdField.Equals(value))
				{
					this.JobIdField = value;
					base.RaisePropertyChanged("JobId");
				}
			}
		}

		[DataMember]
		public Dictionary<int, SetAssetDeletedResponse> ResponseList
		{
			get
			{
				return this.ResponseListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ResponseListField, value))
				{
					this.ResponseListField = value;
					base.RaisePropertyChanged("ResponseList");
				}
			}
		}

		public SetAssetsDeletedResponse()
		{
		}
	}
}