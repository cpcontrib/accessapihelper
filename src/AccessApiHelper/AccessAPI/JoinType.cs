using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="JoinType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum JoinType
	{
		[EnumMember]
		NotSet,
		[EnumMember]
		And,
		[EnumMember]
		Or
	}
}