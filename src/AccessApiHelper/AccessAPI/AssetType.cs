using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum AssetType
	{
		[EnumMember]
		None = 0,
		[EnumMember]
		File = 2,
		[EnumMember]
		Folder = 4,
		[EnumMember]
		Mount = 9,
		[EnumMember]
		Connector = 10
	}
}