using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpAsset.RenderType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum cpAssetRenderType
	{
		[EnumMember]
		ASP_UI,
		[EnumMember]
		SL_UI,
		[EnumMember]
		ViewOutput,
		[EnumMember]
		Download
	}
}