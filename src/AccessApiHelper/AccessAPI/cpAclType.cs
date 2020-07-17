using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpAclType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum cpAclType
	{
		[EnumMember]
		NotSet = 0,
		[EnumMember]
		View = 1,
		[EnumMember]
		CreateFolder = 2,
		[EnumMember]
		CreateFile = 3,
		[EnumMember]
		CreateNewFile = 4,
		[EnumMember]
		Edit = 5,
		[EnumMember]
		Copy = 6,
		[EnumMember]
		Move = 7,
		[EnumMember]
		Route = 8,
		[EnumMember]
		Delete = 9,
		[EnumMember]
		Hide = 10,
		[EnumMember]
		Spell = 12,
		[EnumMember]
		Publish = 13,
		[EnumMember]
		RePublish = 14,
		[EnumMember]
		Clone = 15,
		[EnumMember]
		Revert = 16,
		[EnumMember]
		Checkout = 17,
		[EnumMember]
		Audit = 18,
		[EnumMember]
		Tasks = 19,
		[EnumMember]
		Version = 20,
		[EnumMember]
		Download = 21,
		[EnumMember]
		Rename = 22,
		[EnumMember]
		EditTemplate = 23,
		[EnumMember]
		FilenameConfig = 24,
		[EnumMember]
		SecurityConfig = 25,
		[EnumMember]
		ManageUsers = 26,
		[EnumMember]
		ManageGroups = 27,
		[EnumMember]
		Browse = 28,
		[EnumMember]
		NewModel = 29,
		[EnumMember]
		AuditGroup = 30,
		[EnumMember]
		Insert = 31,
		[EnumMember]
		Refresh = 32,
		[EnumMember]
		EditAgain = 33,
		[EnumMember]
		StartupPref = 34,
		[EnumMember]
		Unlock = 35,
		[EnumMember]
		Preview = 36,
		[EnumMember]
		Goto = 37,
		[EnumMember]
		SetTemplate = 38,
		[EnumMember]
		SetWorkflow = 39,
		[EnumMember]
		Undelete = 40,
		[EnumMember]
		Paste = 41,
		[EnumMember]
		ClearErrors = 42,
		[EnumMember]
		Workflow = 43,
		[EnumMember]
		MultiSet = 44,
		[EnumMember]
		SetModel = 45,
		[EnumMember]
		ExportConfig = 46,
		[EnumMember]
		SystemConfig = 47,
		[EnumMember]
		Branch = 48,
		[EnumMember]
		SetRefresh = 49,
		[EnumMember]
		SetSchedule = 50,
		[EnumMember]
		ViewReports = 52,
		[EnumMember]
		SummaryPref = 54,
		[EnumMember]
		MyModified = 55,
		[EnumMember]
		TaskPref = 56,
		[EnumMember]
		FolderPref = 57,
		[EnumMember]
		OtherPref = 58,
		[EnumMember]
		PublishHistory = 59,
		[EnumMember]
		SystemHistory = 60,
		[EnumMember]
		SetAccess = 61,
		[EnumMember]
		SetPublish = 62,
		[EnumMember]
		SetOptions = 63,
		[EnumMember]
		ShowWorkflows = 64,
		[EnumMember]
		ClearLinkCache = 65,
		[EnumMember]
		RecompileCSharpTemplates = 66,
		[EnumMember]
		CPTAdmin = 67,
		[EnumMember]
		Variables = 68,
		[EnumMember]
		ConfigMatrix = 69,
		[EnumMember]
		DeptTitle = 70,
		[EnumMember]
		SetAlerts = 71,
		[EnumMember]
		ViewGeneral = 72,
		[EnumMember]
		MenuShortcuts = 73,
		[EnumMember]
		DeveloperHelp = 74,
		[EnumMember]
		AdminHelp = 75,
		[EnumMember]
		UserHelp = 76,
		[EnumMember]
		APIHelp = 77,
		[EnumMember]
		Switch = 78,
		[EnumMember]
		ViewContent = 79,
		[EnumMember]
		ViewDependency = 80,
		[EnumMember]
		History = 81,
		[EnumMember]
		FolderHistory = 82,
		[EnumMember]
		Connectors = 83,
		[EnumMember]
		QuickSearch = 84,
		[EnumMember]
		AdvancedSearch = 85,
		[EnumMember]
		Reserved = 86,
		[EnumMember]
		UnBranch = 87,
		[EnumMember]
		Marketplace = 88,
		[EnumMember]
		WCO = 89,
		[EnumMember]
		SetOwner = 90,
		[EnumMember]
		Filter = 91,
		[EnumMember]
		ClearQueue = 92,
		[EnumMember]
		ProviderSettings = 93,
		[EnumMember]
		OrphanContent = 94,
		[EnumMember]
		OrphanContentGenerate = 95,
		[EnumMember]
		SeeOthers = 96,
		[EnumMember]
		MenuConfig = 97,
		[EnumMember]
		EditOwnGroup = 98,
		[EnumMember]
		PasteShortCut = 99,
		[EnumMember]
		CreateProject = 100,
		[EnumMember]
		CreateLibrary = 101,
		[EnumMember]
		CreateSiteRoot = 102,
		[EnumMember]
		CreateTemplateFolder = 103,
		[EnumMember]
		CreateTemplate = 104,
		[EnumMember]
		CreateTemplateFile = 105,
		[EnumMember]
		CreateNewWorkflow = 106,
		[EnumMember]
		Top = 107
	}
}