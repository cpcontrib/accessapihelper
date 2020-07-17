using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ActionType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum ActionType
	{
		[EnumMember]
		SetWorkflow,
		[EnumMember]
		SetTemplate,
		[EnumMember]
		SetModel,
		[EnumMember]
		SetAccess,
		[EnumMember]
		SetPublish,
		[EnumMember]
		SetOptions,
		[EnumMember]
		Route
	}
}