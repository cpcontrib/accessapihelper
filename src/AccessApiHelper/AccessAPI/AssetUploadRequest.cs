using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetUploadRequest
	{
		[DataMember]
		public string newName;

		[DataMember]
		public int destinationFolderId;

		[DataMember]
		public int modelId;

		[DataMember]
		public int workflowId;

		[DataMember]
		public byte[] bytes;

		public AssetUploadRequest()
		{
			this.newName = string.Empty;
			this.destinationFolderId = -1;
			this.modelId = -1;
			this.workflowId = -1;
			this.bytes = null;
		}

		public AssetUploadRequest(string newName, int destinationFolderId)
		{
			this.newName = newName;
			this.destinationFolderId = destinationFolderId;
			this.modelId = -1;
			this.workflowId = -1;
			this.bytes = null;
		}
	}
}