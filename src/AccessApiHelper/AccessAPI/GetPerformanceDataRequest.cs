using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPerformanceDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPerformanceDataRequest : BaseRequest
	{
		private int AssetIdField;

		private string LayoutNameField;

		private string RangeNameField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					base.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public string LayoutName
		{
			get
			{
				return this.LayoutNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LayoutNameField, value))
				{
					this.LayoutNameField = value;
					base.RaisePropertyChanged("LayoutName");
				}
			}
		}

		[DataMember]
		public string RangeName
		{
			get
			{
				return this.RangeNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RangeNameField, value))
				{
					this.RangeNameField = value;
					base.RaisePropertyChanged("RangeName");
				}
			}
		}

		public GetPerformanceDataRequest()
		{
		}
	}
}