using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="BehavioralRuleType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model.Behavioral")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum BehavioralRuleType
	{
		[EnumMember]
		ViewedSnippet,
		[EnumMember]
		ConvertedSnippet,
		[EnumMember]
		ViewedVariant,
		[EnumMember]
		ConvertedVariant,
		[EnumMember]
		ConvertedFromLink
	}
}