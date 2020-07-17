using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetExecuteWorkflowCommandRequest
	{
		[DataMember]
		public int assetId;

		[DataMember]
		public int commandId;

		[DataMember]
		public bool skipDependencies;

		public AssetExecuteWorkflowCommandRequest()
		{
		}
	}
}