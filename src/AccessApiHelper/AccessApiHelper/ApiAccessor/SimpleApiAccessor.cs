using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrownPeak.AccessApiHelper.ApiAccessor
{
	public class SimpleApiAccessor : IApiAccessor, IDisposable
	{
		private const string WEBAPI_ROOT = "/cpt_webservice/accessapi";

		private readonly Encoding _encoding = Encoding.UTF8;

		private string _cookie;

		private bool _authenticated;

		private WebClient _client;

		private string Instance
		{
			get;
			set;
		}

		private string PublicKey
		{
			get;
			set;
		}

		private string Server
		{
			get;
			set;
		}

		public SimpleApiAccessor()
		{
		}

		public void Dispose()
		{
			this.Logout();
		}

		public void Init(string server, string instance, string publicKey)
		{
			this.Server = server;
			this.Instance = instance;
			this.PublicKey = publicKey;
		}

		public void Init(string server, string instance, string publicKey, string privateKey)
		{
			this.Server = server;
			this.Instance = instance;
			this.PublicKey = publicKey;
		}

		public bool Login(string username, string password)
		{
			if (this._authenticated)
			{
				return true;
			}
			LoginRequest loginRequest = new LoginRequest()
			{
				instance = this.Instance,
				username = username,
				password = password,
				remember_me = false,
				timeZoneOffsetMinutes = 0
			};
			string str = JsonConvert.SerializeObject(loginRequest);
			this._client = new WebClient();
			string str1 = this.SendRequest("POST", "/Auth/Authenticate", str);
			this._authenticated = str1.Contains("\"conWS_Success\"");
			if (this._authenticated)
			{
				this._cookie = this._client.ResponseHeaders["Set-Cookie"];
			}
			return this._authenticated;
		}

		public bool Logout()
		{
			if (this._authenticated)
			{
				if (this._client != null)
				{
					this.SendRequest("POST", "/Auth/Logout", "");
					this._client = null;
				}
				this._authenticated = false;
			}
			return true;
		}

		public string SendRequest(string method, string path, string data)
		{
			Task<string> task = this.SendRequestAsync(method, path, data);
			task.Wait();
			return task.Result;
		}

		public Task<string> SendRequestAsync(string method, string path, string data)
		{
			string str1 = path;
			str1 = string.Concat("/", this.Instance, "/cpt_webservice/accessapi", str1);
			DateTime utcNow = DateTime.UtcNow;
			this._client.Headers[HttpRequestHeader.ContentType] = "text/json";
			this._client.Headers["x-api-key"] = this.PublicKey;
			this._client.Encoding = Encoding.UTF8;
			if (this._authenticated && !string.IsNullOrWhiteSpace(this._cookie))
			{
				this._client.Headers.Add(HttpRequestHeader.Cookie, this._cookie);
				this._cookie = null;
			}
			return Task.Run<string>(() => {
				int num;
				string str;
				while (true)
				{
					try
					{
						if (!string.IsNullOrEmpty(data) || !(method.ToUpper() == "GET"))
						{
							str = this._client.UploadString(string.Concat("https://", this.Server, str1), method, data ?? "");
							break;
						}
						else
						{
							str = this._client.DownloadString(string.Concat("https://", this.Server, str1));
							break;
						}
					}
					catch (WebException webException1)
					{
						WebException webException = webException1;
						if (webException.Status != WebExceptionStatus.ProtocolError || !webException.Message.Contains("(429)"))
						{
							throw;
						}
						else
						{
							int num1 = 1000;
							if (webException.Response != null && webException.Response.Headers != null && webException.Response.Headers["Retry-After"] != null && int.TryParse(webException.Response.Headers["Retry-After"], out num))
							{
								num1 = num * 1000;
							}
							Thread.Sleep(num1);
							this._client.Headers["Content-Type"] = "text/json";
						}
					}
				}
				return str;
			});
		}
	}
}