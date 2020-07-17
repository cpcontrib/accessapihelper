using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ReportType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum ReportType
	{
		[EnumMember]
		AssetsWithErrors,
		[EnumMember]
		LastPublished,
		[EnumMember]
		QueuedAssets,
		[EnumMember]
		ModifiedUnpublished,
		[EnumMember]
		NewAssets,
		[EnumMember]
		LockedAssets,
		[EnumMember]
		AssetsNearPublish,
		[EnumMember]
		OldestPages,
		[EnumMember]
		LastModified,
		[EnumMember]
		LoginAlerts,
		[EnumMember]
		MyLockedAssets,
		[EnumMember]
		MyQueuedAssets,
		[EnumMember]
		MyModifiedUnpublished,
		[EnumMember]
		MyLastModified,
		[EnumMember]
		MyAlerts,
		[EnumMember]
		MyFlaggedAssets,
		[EnumMember]
		MyWorkflowTasks,
		[EnumMember]
		AssetSpeed,
		[EnumMember]
		Templates,
		[EnumMember]
		AssetRefresh,
		[EnumMember]
		NeverLoggedIn,
		[EnumMember]
		LeastActiveUsers,
		[EnumMember]
		MostActiveUsers,
		[EnumMember]
		LastLogins,
		[EnumMember]
		SystemSummary,
		[EnumMember]
		PublishSummary,
		[EnumMember]
		AssetPublishSummary
	}
}