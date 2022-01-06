using Microsoft.AspNetCore.Http;
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
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			HttpClient client = new HelperAPI(HttpContext.Session.GetString("usrToken")).Client;
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
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			HttpClient client = new HelperAPI(HttpContext.Session.GetString("usrToken")).Client;
			HttpResponseMessage response = await client.GetAsync($"Colecoes/{id}");

			if (response.IsSuccessStatusCode)
			{
				ColecaoViewModel colecao = await response.Content.ReadAsAsync<ColecaoViewModel>();
				return View(colecao);
			}
			else
				return View("Error");
		}

		public async Task<IActionResult> Cadastrar(string nome)
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			return View(new ColecaoInputModel() { Nome = nome });
		}

		[HttpPost]
		public async Task<IActionResult> Cadastrar(ColecaoInputModel input)
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			input.Nome = "AEEEEE";
			return View(input);
		}
	}
}
