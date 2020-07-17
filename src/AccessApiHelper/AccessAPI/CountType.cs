using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CountType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model.Response")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum CountType
	{
		[EnumMember]
		All,
		[EnumMember]
		Referrer,
		[EnumMember]
		ScreenSize,
		[EnumMember]
		Country,
		[EnumMember]
		OS,
		[EnumMember]
		Browser,
		[EnumMember]
		Language,
		[EnumMember]
		Asset
	}
}