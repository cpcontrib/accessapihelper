using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SnippetVariantType", Namespace="http://schemas.datacontract.org/2004/07/")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum SnippetVariantType
	{
		[EnumMember]
		Original,
		[EnumMember]
		Testing,
		[EnumMember]
		Targeting
	}
}