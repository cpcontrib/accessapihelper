using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DeploymentType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum DeploymentType
	{
		[EnumMember]
		NotSet,
		[EnumMember]
		HtmlDeployment,
		[EnumMember]
		AssetDeployment
	}
}