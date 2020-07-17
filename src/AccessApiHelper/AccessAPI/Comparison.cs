using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Comparison", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum Comparison
	{
		[EnumMember]
		NotSet,
		[EnumMember]
		GreaterThan,
		[EnumMember]
		GreaterOrEquals,
		[EnumMember]
		LessThan,
		[EnumMember]
		LessOrEquals,
		[EnumMember]
		Equals,
		[EnumMember]
		NotEquals,
		[EnumMember]
		NotNull,
		[EnumMember]
		IsNull,
		[EnumMember]
		IsInSet,
		[EnumMember]
		NotInSet,
		[EnumMember]
		StartsWith,
		[EnumMember]
		EndsWith,
		[EnumMember]
		Contains
	}
}