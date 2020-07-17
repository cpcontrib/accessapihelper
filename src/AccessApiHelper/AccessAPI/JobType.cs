using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="JobType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum JobType
	{
		[EnumMember]
		Unspecified,
		[EnumMember]
		CopyAsset,
		[EnumMember]
		CloneAsset,
		[EnumMember]
		CopyAssets,
		[EnumMember]
		MoveAsset,
		[EnumMember]
		MoveAssets,
		[EnumMember]
		SetAssetDeleted,
		[EnumMember]
		SetAssetsDeleted,
		[EnumMember]
		RouteAsset,
		[EnumMember]
		RouteAssets,
		[EnumMember]
		SetAssetFields,
		[EnumMember]
		ConvertToNewStorage,
		[EnumMember]
		GenerateThumbnails,
		[EnumMember]
		FindOrphanReport,
		[EnumMember]
		ReadEmailImport
	}
}