using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetCreateRequest
	{
		[DataMember]
		public string newName;

		[DataMember]
		public int destinationFolderId;

		[DataMember]
		public int modelId;

		[DataMember]
		public int type;

		[DataMember]
		public int devTemplateLanguage;

		[DataMember]
		public int templateId;

		[DataMember]
		public int workflowId;

		[DataMember]
		public int subtype;

		[DataMember]
		public bool runNew;

		public AssetCreateRequest()
		{
			this.destinationFolderId = -1;
			this.newName = string.Empty;
			this.type = -1;
			this.modelId = -1;
			this.workflowId = -1;
			this.templateId = -1;
			this.subtype = -1;
			this.runNew = false;
		}

		public AssetCreateRequest(string newName, int destinationFolderId, AssetType type)
		{
			this.destinationFolderId = destinationFolderId;
			this.newName = newName;
			this.type = (int)type;
			this.modelId = -1;
			this.workflowId = -1;
			this.templateId = -1;
			this.subtype = -1;
			this.runNew = false;
		}
	}
}