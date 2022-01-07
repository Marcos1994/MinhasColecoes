using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MinhasColecoes.MinhasColecoesAPI.Services
{
	public class HelperAPI
	{
		private readonly string url = "https://localhost:5001";
		//private readonly string url = "https://localhost:44308";
		public HttpClient Client { get; private set; }

		public HelperAPI(string? token = null)
		{
			Client = new HttpClient();
			Client.BaseAddress = new Uri(url);
			if (token != null)
				Client.DefaultRequestHeaders.Authorization =
					new AuthenticationHeaderValue("Bearer", token);
		}
	}
}
