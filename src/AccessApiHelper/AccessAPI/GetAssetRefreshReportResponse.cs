using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetRefreshReportResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetRefreshReportResponse : WSResultClass
	{
		private int AssetIdField;

		private ICollection<AssetRefreshReportData> AssetRefreshField;

		private ICollection<AssetRefreshReportData> WorkflowStepRefreshField;

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
		public ICollection<AssetRefreshReportData> AssetRefresh
		{
			get
			{
				return this.AssetRefreshField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetRefreshField, value))
				{
					this.AssetRefreshField = value;
					base.RaisePropertyChanged("AssetRefresh");
				}
			}
		}

		[DataMember]
		public ICollection<AssetRefreshReportData> WorkflowStepRefresh
		{
			get
			{
				return this.WorkflowStepRefreshField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowStepRefreshField, value))
				{
					this.WorkflowStepRefreshField = value;
					base.RaisePropertyChanged("WorkflowStepRefresh");
				}
			}
		}

		public GetAssetRefreshReportResponse()
		{
		}
	}
}