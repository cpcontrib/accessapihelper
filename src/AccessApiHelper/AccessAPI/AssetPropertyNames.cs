using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetPropertyNames", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum AssetPropertyNames
	{
		[EnumMember]
		Unspecified,
		[EnumMember]
		Id,
		[EnumMember]
		FolderId,
		[EnumMember]
		CreateDate,
		[EnumMember]
		ModifiedDate,
		[EnumMember]
		ChangeDate,
		[EnumMember]
		CheckedOutDate,
		[EnumMember]
		Label,
		[EnumMember]
		CreatedFromModel,
		[EnumMember]
		Model,
		[EnumMember]
		ShortcutId,
		[EnumMember]
		BranchId,
		[EnumMember]
		PublishDate,
		[EnumMember]
		Type,
		[EnumMember]
		StatusDate,
		[EnumMember]
		ModifiedBy,
		[EnumMember]
		ChangedBy,
		[EnumMember]
		CreatedBy,
		[EnumMember]
		CheckedOutBy,
		[EnumMember]
		LastPublishedBy,
		[EnumMember]
		LastStatusBy,
		[EnumMember]
		Status,
		[EnumMember]
		Workflow,
		[EnumMember]
		Template,
		[EnumMember]
		TemplateID
	}
}