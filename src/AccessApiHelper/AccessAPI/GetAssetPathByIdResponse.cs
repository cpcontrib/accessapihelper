using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetPathByIdResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetPathByIdResponse : WSResultClass
	{
		private ICollection<WorklistAsset> listField;

		private string pathField;

		[DataMember]
		public ICollection<WorklistAsset> list
		{
			get
			{
				return this.listField;
			}
			set
			{
				if (!object.ReferenceEquals(this.listField, value))
				{
					this.listField = value;
					base.RaisePropertyChanged("list");
				}
			}
		}

		[DataMember]
		public string path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.pathField, value))
				{
					this.pathField = value;
					base.RaisePropertyChanged("path");
				}
			}
		}

		public GetAssetPathByIdResponse()
		{
		}
	}
}