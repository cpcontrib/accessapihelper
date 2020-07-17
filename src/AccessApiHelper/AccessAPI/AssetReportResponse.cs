using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetReportResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetReportResponse : WSResultClass
	{
		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		private ICollection<WorklistAsset> assetsField;

		[DataMember]
		public ICollection<WorklistAsset> assets
		{
			get
			{
				return this.assetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetsField, value))
				{
					this.assetsField = value;
					base.RaisePropertyChanged("assets");
				}
			}
		}

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

		public AssetReportResponse()
		{
		}
	}
}