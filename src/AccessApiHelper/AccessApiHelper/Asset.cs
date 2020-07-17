using CrownPeak.AccessAPI;
using CrownPeak.AccessApiHelper.ApiAccessor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CrownPeak.AccessApiHelper
{
	public class Asset
	{
		private IApiAccessor _api;

		internal Asset(IApiAccessor api)
		{
			this._api = api;
		}

		public bool Attach(int id, string filename, byte[] bytes, out string displayUrl)
		{
			AssetAttachRequest assetAttachRequest = new AssetAttachRequest()
			{
				assetId = id,
				originalFilename = filename,
				bytes = bytes
			};
			string str = JsonConvert.SerializeObject(assetAttachRequest);
			string str1 = this._api.SendRequest("POST", string.Format("/Asset/Attach", new object[0]), str);
			AssetAttachResponse assetAttachResponse = JsonConvert.DeserializeObject<AssetAttachResponse>(str1);
			displayUrl = assetAttachResponse.displayUrl;
			return assetAttachResponse.IsSuccessful;
		}

		public bool Branch(int id, out WorklistAsset asset)
		{
			string str = this._api.SendRequest("POST", string.Format("/Asset/Branch/{0}", id), "");
			AssetBranchResponse assetBranchResponse = JsonConvert.DeserializeObject<AssetBranchResponse>(str);
			asset = assetBranchResponse.asset;
			return assetBranchResponse.IsSuccessful;
		}

		public bool Create(string name, int folderId, int modelId, int type, int devTemplateLanguage, int templateId, int workflowId, out WorklistAsset asset, int? subtype = null, bool? runNew = null)
		{
			AssetCreateRequest assetCreateRequest = new AssetCreateRequest()
			{
				newName = name,
				destinationFolderId = folderId,
				modelId = modelId,
				type = type,
				devTemplateLanguage = devTemplateLanguage,
				templateId = templateId,
				workflowId = workflowId
			};
			AssetCreateRequest value = assetCreateRequest;
			if (subtype.HasValue)
			{
				value.subtype = subtype.Value;
			}
			if (runNew.HasValue)
			{
				value.runNew = runNew.Value;
			}
			string str = JsonConvert.SerializeObject(value);
			string str1 = this._api.SendRequest("POST", "/Asset/Create", str);
			AssetCreateResponse assetCreateResponse = JsonConvert.DeserializeObject<AssetCreateResponse>(str1);
			asset = assetCreateResponse.asset;
			return assetCreateResponse.IsSuccessful;
		}

		public bool Delete(int id)
		{
			string str = this._api.SendRequest("POST", string.Format("/Asset/Delete/{0}", id), "");
			return JsonConvert.DeserializeObject<AssetDeleteResponse>(str).IsSuccessful;
		}

		public bool ExecuteWorkflowCommand(int id, int commandId, bool skipDependencies, out WorklistAsset asset)
		{
			ExecuteWorkflowCommandRequest executeWorkflowCommandRequest = new ExecuteWorkflowCommandRequest()
			{
				AssetId = id,
				CommandId = commandId,
				SkipDependencies = skipDependencies
			};
			string str = JsonConvert.SerializeObject(executeWorkflowCommandRequest);
			string str1 = this._api.SendRequest("POST", "/Asset/ExecuteWorkflowCommand", str);
			AssetExecuteWorkflowCommandResponse assetExecuteWorkflowCommandResponse = JsonConvert.DeserializeObject<AssetExecuteWorkflowCommandResponse>(str1);
			asset = assetExecuteWorkflowCommandResponse.asset;
			return assetExecuteWorkflowCommandResponse.IsSuccessful;
		}

		public bool Exists(string idOrPath, out int id)
		{
			id = -1;
			AssetExistsRequest assetExistsRequest = new AssetExistsRequest()
			{
				assetIdOrPath = idOrPath
			};
			string str = JsonConvert.SerializeObject(assetExistsRequest);
			string str1 = this._api.SendRequest("POST", string.Format("/Asset/Exists", new object[0]), str);
			id = int.Parse(Regex.Match(str1, "\"assetId\": ([0-9\\-]+),").Groups[1].Value);
			return str1.Contains("\"exists\": true,");
		}

		public IDictionary<string, string> Fields(int id)
		{
			string str = this._api.SendRequest("POST", string.Format("/Asset/Fields/{0}", id), "");
			AssetFieldsResponse assetFieldsResponse = JsonConvert.DeserializeObject<AssetFieldsResponse>(str);
			if (!assetFieldsResponse.IsSuccessful)
			{
				return null;
			}
			return assetFieldsResponse.fields.ToDictionary<AssetsField, string, string>((AssetsField f) => f.name, (AssetsField f) => f.@value);
		}

		public bool GetList(int id, int currentPage, int pageSize, string sortColumn, OrderType orderType, VisibilityType visibilityType, bool ignoreFilter, bool ignoreSort, out IEnumerable<WorklistAsset> assets, out int normalCount, out int hiddenCount, out int deletedCount)
		{
			AssetPagedRequest assetPagedRequest = new AssetPagedRequest()
			{
				assetId = id,
				currentPage = currentPage,
				pageSize = pageSize,
				sortColumn = sortColumn,
				orderType = orderType,
				visibilityType = visibilityType,
				ignoreFilter = ignoreFilter,
				ignoreSort = ignoreSort
			};
			AssetPagedRequest assetPagedRequest1 = assetPagedRequest;
			string str = this._api.SendRequest("POST", "/Asset/Paged", JsonConvert.SerializeObject(assetPagedRequest1));
			AssetPagedResponse assetPagedResponse = JsonConvert.DeserializeObject<AssetPagedResponse>(str);
			assets = assetPagedResponse.assets;
			normalCount = assetPagedResponse.normalCount;
			hiddenCount = assetPagedResponse.hiddenCount;
			deletedCount = assetPagedResponse.deletedCount;
			return assetPagedResponse.IsSuccessful;
		}

		public bool Read(int id, out WorklistAsset asset)
		{
			string str = this._api.SendRequest("POST", string.Format("/Asset/Read/{0}", id), "");
			AssetReadByIdResponse assetReadByIdResponse = JsonConvert.DeserializeObject<AssetReadByIdResponse>(str);
			asset = assetReadByIdResponse.asset;
			return assetReadByIdResponse.IsSuccessful;
		}

		public bool Rename(int id, string newName, out WorklistAsset asset)
		{
			RenameAssetRequest renameAssetRequest = new RenameAssetRequest()
			{
				assetId = id,
				newName = newName
			};
			string str = JsonConvert.SerializeObject(renameAssetRequest);
			string str1 = this._api.SendRequest("POST", "/Asset/Rename", str);
			AssetRenameResponse assetRenameResponse = JsonConvert.DeserializeObject<AssetRenameResponse>(str1);
			asset = assetRenameResponse.asset;
			return assetRenameResponse.IsSuccessful;
		}

		public bool Route(int id, int stateId)
		{
			RouteAssetRequest routeAssetRequest = new RouteAssetRequest()
			{
				AssetId = id,
				StateId = stateId
			};
			string str = JsonConvert.SerializeObject(routeAssetRequest);
			string str1 = this._api.SendRequest("POST", "/Asset/Route", str);
			return JsonConvert.DeserializeObject<AssetRouteResponse>(str1).IsSuccessful;
		}

		public bool Route(int id, string state)
		{
			int num;
			if (!this.Exists(string.Format("/System/States/{0}", state), out num))
			{
				return false;
			}
			return this.Route(id, num);
		}

		public bool Undelete(int id)
		{
			string str = this._api.SendRequest("POST", string.Format("/Asset/Undelete/{0}", id), "");
			return JsonConvert.DeserializeObject<AssetUndeleteResponse>(str).IsSuccessful;
		}

		public bool Update(int id, IDictionary<string, string> fields, out WorklistAsset asset, List<string> fieldsToDelete = null, bool runPostInput = false, bool runPostSave = false)
		{
			AssetUpdateRequest assetUpdateRequest = new AssetUpdateRequest()
			{
				assetId = id,
				fields = (Dictionary<string, string>)fields,
				runPostInput = runPostInput,
				runPostSave = runPostSave
			};
			AssetUpdateRequest assetUpdateRequest1 = assetUpdateRequest;
			if (fieldsToDelete != null)
			{
				assetUpdateRequest1.fieldsToDelete = fieldsToDelete;
			}
			string str = this._api.SendRequest("POST", "/Asset/Update", JsonConvert.SerializeObject(assetUpdateRequest1));
			AssetUpdateResponse assetUpdateResponse = JsonConvert.DeserializeObject<AssetUpdateResponse>(str);
			asset = assetUpdateResponse.asset;
			return assetUpdateResponse.IsSuccessful;
		}

		public bool Upload(string name, int folderId, int modelId, int workflowId, byte[] bytes, out WorklistAsset asset)
		{
			AssetUploadRequest assetUploadRequest = new AssetUploadRequest()
			{
				newName = name,
				destinationFolderId = folderId,
				modelId = modelId,
				workflowId = workflowId,
				bytes = bytes
			};
			string str = JsonConvert.SerializeObject(assetUploadRequest);
			string str1 = this._api.SendRequest("POST", string.Format("/Asset/Upload", new object[0]), str);
			AssetUploadResponse assetUploadResponse = JsonConvert.DeserializeObject<AssetUploadResponse>(str1);
			asset = assetUploadResponse.asset;
			return assetUploadResponse.IsSuccessful;
		}
	}
}