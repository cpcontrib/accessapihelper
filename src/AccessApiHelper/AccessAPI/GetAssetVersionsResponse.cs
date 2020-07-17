using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetVersionsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetVersionsResponse : WSResultClass
	{
		private ICollection<VersionReportData> assetVersionsField;

		private int returnedCountField;

		private int totalCountField;

		[DataMember]
		public ICollection<VersionReportData> assetVersions
		{
			get
			{
				return this.assetVersionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetVersionsField, value))
				{
					this.assetVersionsField = value;
					base.RaisePropertyChanged("assetVersions");
				}
			}
		}

		[DataMember]
		public int returnedCount
		{
			get
			{
				return this.returnedCountField;
			}
			set
			{
				if (!this.returnedCountField.Equals(value))
				{
					this.returnedCountField = value;
					base.RaisePropertyChanged("returnedCount");
				}
			}
		}

		[DataMember]
		public int totalCount
		{
			get
			{
				return this.totalCountField;
			}
			set
			{
				if (!this.totalCountField.Equals(value))
				{
					this.totalCountField = value;
					base.RaisePropertyChanged("totalCount");
				}
			}
		}

		public GetAssetVersionsResponse()
		{
		}
	}
}