using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PreferenceDataType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum PreferenceDataType
	{
		[EnumMember]
		HomeFileOrFolder,
		[EnumMember]
		LoginView,
		[EnumMember]
		NotifyDowntime,
		[EnumMember]
		EmailAlerts,
		[EnumMember]
		DefaultSortFolderBy,
		[EnumMember]
		FolderPageSize,
		[EnumMember]
		PreviewState,
		[EnumMember]
		Culture,
		[EnumMember]
		ShowDebugConsole,
		[EnumMember]
		NotificationMode,
		[EnumMember]
		NotificationErrorDetail,
		[EnumMember]
		WysiwygEditor,
		[EnumMember]
		TimezoneDisplayName,
		[EnumMember]
		EditMode,
		[EnumMember]
		SkipDependenciesDefault,
		[EnumMember]
		ShowRuntimeErrorDetail
	}
}