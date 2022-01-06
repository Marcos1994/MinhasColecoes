using Microsoft.AspNetCore.Mvc;
using MinhasColecoes.Helper;
using MinhasColecoes.Models.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MinhasColecoes.Controllers
{
	public class ColecaoController : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Index(string nome = "")
		{
			HttpClient client = new HelperAPI().Client;
			IEnumerable<ColecaoBasicViewModel> colecoes = null;

			HttpResponseMessage response = await client
				.GetAsync((nome != null && nome.Length > 0)
				? $"Colecoes?nome={nome}"
				: $"Colecoes");
			if (response.IsSuccessStatusCode)
			{
				var result = response.Content.ReadAsAsync<IList<ColecaoBasicViewModel>>();
				result.Wait();
				colecoes = result.Result;
			}
			else
			{
				colecoes = Enumerable.Empty<ColecaoBasicViewModel>();
				ModelState.AddModelError(string.Empty, "Deu ruim...");
			}

			return View(colecoes);
		}

		[HttpGet]
		public async Task<IActionResult> Visualizar(int id)
		{
			HttpClient client = new HelperAPI().Client;
			HttpResponseMessage response = await client.GetAsync($"Colecoes/{id}");
			ColecaoViewModel colecao = (response.IsSuccessStatusCode)
				? await response.Content.ReadAsAsync<ColecaoViewModel>()
				: new ColecaoViewModel();
			return View(colecao);
		}

		public async Task<IActionResult> Cadastrar(string nome)
		{
			return View(new ColecaoInputModel() { Nome = nome });
		}

		[HttpPost]
		public async Task<IActionResult> Cadastrar(ColecaoInputModel input)
		{
			input.Nome = "AEEEEE";
			return View(input);
		}
	}
}
