﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MinhasColecoes.Helper
{
	public class HelperAPI
	{
		private readonly string url = "https://localhost:44308";
		public HttpClient Client { get; private set; }

		public HelperAPI()
		{
			Client = new HttpClient();
			Client.BaseAddress = new Uri(url);
		}
		public HelperAPI(string token)
			: base()
		{
			Client.DefaultRequestHeaders.Authorization =
				new AuthenticationHeaderValue("Bearer", token);
		}
	}
}
