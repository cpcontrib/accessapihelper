using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpWorkflowActionRequired", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.App")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum cpWorkflowActionRequired
	{
		[EnumMember]
		None,
		[EnumMember]
		Edit,
		[EnumMember]
		SpellCheck,
		[EnumMember]
		SetSchedule
	}
}