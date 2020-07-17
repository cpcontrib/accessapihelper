using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpDiagnosticsError.errorCodes", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum cpDiagnosticsErrorerrorCodes
	{
		[EnumMember]
		ERROR_PARSE_MISMATCH = 9000,
		[EnumMember]
		ERROR_QUOTE_MISMATCH = 9001,
		[EnumMember]
		ERROR_DYNAMIC_MISMATCH = 9002,
		[EnumMember]
		ERROR_MISSING_PARAMETER = 9003,
		[EnumMember]
		ERROR_PARENTHESES_MISMATCH = 9004
	}
}