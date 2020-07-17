using CrownPeak.AccessApiHelper.ApiAccessor;
using System;
using System.Runtime.CompilerServices;

namespace CrownPeak.AccessApiHelper
{
	public class CmsApi
	{
		private readonly IApiAccessor _accessor;

		public CrownPeak.AccessApiHelper.Asset Asset
		{
			get;
			private set;
		}

		public CrownPeak.AccessApiHelper.Util Util
		{
			get;
			private set;
		}

		public CrownPeak.AccessApiHelper.Workflow Workflow
		{
			get;
			private set;
		}

		public CmsApi(IApiAccessor accessor)
		{
			this._accessor = accessor;
			this.Asset = new CrownPeak.AccessApiHelper.Asset(this._accessor);
			this.Workflow = new CrownPeak.AccessApiHelper.Workflow(this._accessor);
			this.Util = new CrownPeak.AccessApiHelper.Util(this._accessor);
		}

		public void Init(string server, string instance, string publicKey)
		{
			this._accessor.Init(server, instance, publicKey, string.Empty);
		}

		public void Init(string server, string instance, string publicKey, string privateKey)
		{
			this._accessor.Init(server, instance, publicKey, privateKey);
		}

		public bool Login(string username, string password)
		{
			return this._accessor.Login(username, password);
		}

		public void Logout()
		{
			this._accessor.Logout();
		}
	}
}