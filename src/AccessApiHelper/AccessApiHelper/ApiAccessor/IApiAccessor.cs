using System;
using System.Threading.Tasks;

namespace CrownPeak.AccessApiHelper.ApiAccessor
{
	public interface IApiAccessor : IDisposable
	{
		void Init(string server, string instance, string publicKey);

		void Init(string server, string instance, string publicKey, string privateKey);

		bool Login(string username, string password);

		bool Logout();

		string SendRequest(string method, string path, string data);

		Task<string> SendRequestAsync(string method, string path, string data);
	}
}