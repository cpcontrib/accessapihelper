using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishRefreshListResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishRefreshListResponse : WSResultClass
	{
		private Dictionary<int, PublishRefreshResponse> ResponseListField;

		[DataMember]
		public Dictionary<int, PublishRefreshResponse> ResponseList
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

		public PublishRefreshListResponse()
		{
		}
	}
}