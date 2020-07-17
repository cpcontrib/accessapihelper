using CrownPeak.AccessAPI;
using CrownPeak.AccessApiHelper.ApiAccessor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CrownPeak.AccessApiHelper
{
	public class Workflow
	{
		private IApiAccessor _api;

		internal Workflow(IApiAccessor api)
		{
			this._api = api;
		}

		public bool GetList(out Dictionary<int, WorkflowData> workflows)
		{
			string str = this._api.SendRequest("POST", "/Workflow/Read", "");
			WorkflowReadResponse workflowReadResponse = JsonConvert.DeserializeObject<WorkflowReadResponse>(str);
			workflows = workflowReadResponse.workflows;
			return workflowReadResponse.IsSuccessful;
		}

		public bool Read(int id, out WorkflowData workflow)
		{
			string str = this._api.SendRequest("POST", string.Format("/Workflow/Read/{0}", id), "");
			WorkflowReadByIdResponse workflowReadByIdResponse = JsonConvert.DeserializeObject<WorkflowReadByIdResponse>(str);
			workflow = workflowReadByIdResponse.workflow;
			return workflowReadByIdResponse.IsSuccessful;
		}
	}
}