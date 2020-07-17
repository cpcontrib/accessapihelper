using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RuleType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum RuleType
	{
		[EnumMember]
		Is,
		[EnumMember]
		IsNot,
		[EnumMember]
		Contains,
		[EnumMember]
		DoesNotContain,
		[EnumMember]
		StartsWith,
		[EnumMember]
		EndsWith,
		[EnumMember]
		GreaterThan,
		[EnumMember]
		GreaterThanEqual,
		[EnumMember]
		LessThan,
		[EnumMember]
		LessThanEqual,
		[EnumMember]
		IsNull,
		[EnumMember]
		IsNotNull,
		[EnumMember]
		IsContainedIn,
		[EnumMember]
		IsNotContainedIn
	}
}