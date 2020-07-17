using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RelatedAssetType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum RelatedAssetType
	{
		[EnumMember]
		DeployCommon,
		[EnumMember]
		FolderSiblings,
		[EnumMember]
		FolderChildren,
		[EnumMember]
		FileChildren,
		[EnumMember]
		FileSiblings,
		[EnumMember]
		Neighborhood,
		[EnumMember]
		Templates,
		[EnumMember]
		Models,
		[EnumMember]
		Labels,
		[EnumMember]
		Workflow,
		[EnumMember]
		Status,
		[EnumMember]
		WorkflowAndStatus
	}
}