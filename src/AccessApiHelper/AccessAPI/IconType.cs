using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="IconType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum IconType
	{
		[EnumMember]
		Asset,
		[EnumMember]
		Folder,
		[EnumMember]
		Custom_Default,
		[EnumMember]
		Developer,
		[EnumMember]
		Redirect,
		[EnumMember]
		Utility,
		[EnumMember]
		Page,
		[EnumMember]
		Configuration,
		[EnumMember]
		Widget,
		[EnumMember]
		Reports,
		[EnumMember]
		Input_Only,
		[EnumMember]
		Branch,
		[EnumMember]
		Flag,
		[EnumMember]
		Asset_Doc,
		[EnumMember]
		Asset_Excel,
		[EnumMember]
		Asset_Img,
		[EnumMember]
		Asset_Mov,
		[EnumMember]
		Asset_Pdf,
		[EnumMember]
		Asset_Music,
		[EnumMember]
		SubAsset,
		[EnumMember]
		Data,
		[EnumMember]
		Developer_Output,
		[EnumMember]
		Sitemap,
		[EnumMember]
		Wysiwyg,
		[EnumMember]
		Purple_Folder,
		[EnumMember]
		Green_Folder,
		[EnumMember]
		Red_Folder,
		[EnumMember]
		Yellow_Folder,
		[EnumMember]
		Custom_Default_Folder,
		[EnumMember]
		Asset_HTML5,
		[EnumMember]
		Asset_CSS3,
		[EnumMember]
		Asset_Facebook,
		[EnumMember]
		Asset_Twitter,
		[EnumMember]
		Asset_GooglePlus,
		[EnumMember]
		Asset_LinkedIn,
		[EnumMember]
		Locked_Folder,
		[EnumMember]
		Asset_Workflow
	}
}