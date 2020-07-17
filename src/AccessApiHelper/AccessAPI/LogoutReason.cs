using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="LogoutReason", Namespace="http://schemas.datacontract.org/2004/07/")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum LogoutReason
	{
		[EnumMember]
		NotSpecified,
		[EnumMember]
		SignOut,
		[EnumMember]
		Timeout
	}
}