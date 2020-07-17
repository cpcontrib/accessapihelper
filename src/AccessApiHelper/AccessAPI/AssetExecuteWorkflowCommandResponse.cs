using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetExecuteWorkflowCommandResponse : ResultClass
	{
		[DataMember]
		public cpWorkflowActionRequired requiredAction;

		[DataMember]
		public WorklistAsset asset;

		[DataMember]
		public int publishingSessionId;

		public AssetExecuteWorkflowCommandResponse()
		{
		}

		public AssetExecuteWorkflowCommandResponse(ResultClass result, cpWorkflowActionRequired requiredAction, int publishingSessionId, WorklistAsset asset) : base(result)
		{
			this.requiredAction = requiredAction;
			this.publishingSessionId = publishingSessionId;
			this.asset = asset;
		}
	}
}