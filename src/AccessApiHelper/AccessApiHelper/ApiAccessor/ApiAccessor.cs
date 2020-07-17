using CrownPeak.AccessApiHelper;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrownPeak.AccessApiHelper.ApiAccessor
{
	public class ApiAccessor : IApiAccessor, IDisposable
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

		private string PrivateKey
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

		public ApiAccessor()
		{
		}

		public void Dispose()
		{
			this.Logout();
		}

		private string EncodeDateTime(DateTime dt)
		{
			return string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffffffZ}", dt);
		}

		private string EncodeHash(byte[] hash)
		{
			return Convert.ToBase64String(hash);
		}

		private string GetSignature(string method, string path, string data, DateTime timestamp)
		{
			object[] upper = new object[] { method.ToUpper(), path, data, this.EncodeDateTime(timestamp) };
			string str = string.Format("{0}\n{1}\n{2}\n{3}", upper);
			HMACSHA1 hMACSHA1 = new HMACSHA1(this._encoding.GetBytes(this.PrivateKey));
			string str1 = this.EncodeHash(hMACSHA1.ComputeHash(this._encoding.GetBytes(str)));
			return str1;
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
			this.PrivateKey = privateKey;
		}

		public bool Login(string username, string password)
		{
			if (this._authenticated)
			{
				return true;
			}
			if (string.IsNullOrWhiteSpace(this.PublicKey))
			{
				throw new Exception("You must initialize using a Public Key");
			}
			string str = string.Format("{{\"instance\":\"{0}\",\"username\":\"{1}\",\"password\":\"{2}\",\"remember_me\":false,\"timeZoneOffsetMinutes\":0}}", CrownPeak.AccessApiHelper.Utils.TidyForJson(this.Instance), CrownPeak.AccessApiHelper.Utils.TidyForJson(username), CrownPeak.AccessApiHelper.Utils.TidyForJson(password));
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
			this._client.Headers[HttpRequestHeader.Authorization] = string.Concat("CP ", this.PublicKey, ":", this.GetSignature(method, str1, data, utcNow));
			this._client.Headers["cp-datetime"] = this.EncodeDateTime(utcNow);
			this._client.Encoding = Encoding.UTF8;
			if (this._authenticated && !string.IsNullOrWhiteSpace(this._cookie))
			{
				this._client.Headers.Add(HttpRequestHeader.Cookie, this._cookie);
				this._cookie = null;
			}
			return Task.Run<string>(() => {
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
							Thread.Sleep(1000);
							this._client.Headers["Content-Type"] = "text/json";
						}
					}
				}
				return str;
			});
		}
	}
}