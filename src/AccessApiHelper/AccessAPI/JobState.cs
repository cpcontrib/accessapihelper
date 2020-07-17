using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="JobState", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum JobState
	{
		[EnumMember]
		ReadyForEnqueue = 0,
		[EnumMember]
		Enqueue = 5,
		[EnumMember]
		ReadyForProcessing = 10,
		[EnumMember]
		Started = 11,
		[EnumMember]
		Starving = 20,
		[EnumMember]
		Successful = 80,
		[EnumMember]
		ManualStop = 85,
		[EnumMember]
		Error = 90
	}
}