using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetAndChildrenByIdResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetAndChildrenByIdResponse : WSResultClass
	{
		private ICollection<WorklistAsset> ChildrenField;

		private WorklistAsset ModelField;

		[DataMember]
		public ICollection<WorklistAsset> Children
		{
			get
			{
				return this.ChildrenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ChildrenField, value))
				{
					this.ChildrenField = value;
					base.RaisePropertyChanged("Children");
				}
			}
		}

		[DataMember]
		public WorklistAsset Model
		{
			get
			{
				return this.ModelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ModelField, value))
				{
					this.ModelField = value;
					base.RaisePropertyChanged("Model");
				}
			}
		}

		public GetAssetAndChildrenByIdResponse()
		{
		}
	}
}