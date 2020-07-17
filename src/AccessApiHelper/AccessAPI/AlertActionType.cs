using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AlertActionType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum AlertActionType
	{
		[EnumMember]
		Default = 0,
		[EnumMember]
		Unhidden = 2,
		[EnumMember]
		Hidden = 4,
		[EnumMember]
		Published = 6,
		[EnumMember]
		Removed = 7,
		[EnumMember]
		Deleted = 12,
		[EnumMember]
		SpellChecked = 14,
		[EnumMember]
		Edited = 15,
		[EnumMember]
		Scheduled = 21,
		[EnumMember]
		Renamed = 24,
		[EnumMember]
		CreatedFolder = 27,
		[EnumMember]
		Copied = 28,
		[EnumMember]
		Moved = 29,
		[EnumMember]
		Cloned = 30,
		[EnumMember]
		CheckedOut = 31,
		[EnumMember]
		CheckedIn = 32,
		[EnumMember]
		Downloaded = 33,
		[EnumMember]
		UploadedNewDocument = 34,
		[EnumMember]
		Unlocked = 35,
		[EnumMember]
		ChangedTemplateProp = 36,
		[EnumMember]
		ChangedMetaProp = 37,
		[EnumMember]
		ChangedPublishProp = 38,
		[EnumMember]
		ChangedAccessProp = 39,
		[EnumMember]
		Created = 52,
		[EnumMember]
		Reverted = 56,
		[EnumMember]
		ChangedAlertProp = 57,
		[EnumMember]
		ChangedModelProp = 58,
		[EnumMember]
		UnDeleted = 60,
		[EnumMember]
		AutoDeleted = 61,
		[EnumMember]
		AutoPublished = 63,
		[EnumMember]
		Republished = 64,
		[EnumMember]
		ChangedWorkflowProp = 66,
		[EnumMember]
		LockExpired = 67,
		[EnumMember]
		ChangedOptionProp = 68,
		[EnumMember]
		Branched = 69,
		[EnumMember]
		CommentAdded = 75,
		[EnumMember]
		UnBranched = 81,
		[EnumMember]
		UploadedReplacingDocument = 83,
		[EnumMember]
		CommentDeleted = 86,
		[EnumMember]
		Previewed = 87,
		[EnumMember]
		Browsed = 88
	}
}