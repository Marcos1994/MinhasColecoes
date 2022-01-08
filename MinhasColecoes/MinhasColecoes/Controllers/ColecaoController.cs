using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhasColecoes.MinhasColecoesAPI.InputModels;
using MinhasColecoes.MinhasColecoesAPI.Services;
using MinhasColecoes.MinhasColecoesAPI.ViewModels;
using MinhasColecoes.Util;
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
		private readonly IWebHostEnvironment _webHostEnv;

		public ColecaoController(IWebHostEnvironment webHostEnv)
		{
			_webHostEnv = webHostEnv;
		}

		[HttpGet]
		public async Task<IActionResult> Index(string nome = "")
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			ViewBag.NomeColecaoBusca = nome;
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
			ViewBag.IdUsuario = HttpContext.Session.GetString("usrId");
			HttpClient client = new HelperAPI(HttpContext.Session.GetString("usrToken")).Client;
			HttpResponseMessage response = await client.GetAsync($"Colecoes/{id}");

			if (!response.IsSuccessStatusCode)
				return View("Error");

			ColecaoViewModel colecao = await response.Content.ReadAsAsync<ColecaoViewModel>();
			if(colecao.IdColecaoMaior != null)
			{
				response = await client.GetAsync($"Colecoes/{colecao.IdColecaoMaior}/Genealogia");
				colecao.ColecaoMaior = await response.Content.ReadAsAsync<ColecaoGenealogiaViewModel>();
			}
			return View(colecao);
		}

		public IActionResult Cadastro(ColecaoInputModel input)
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			return View(input);
		}

		public async Task<IActionResult> CadastroSubcolecao(int id)
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");

			HttpClient client = new HelperAPI(HttpContext.Session.GetString("usrToken")).Client;
			HttpResponseMessage response = await client.GetAsync($"Colecoes/{id}");

			if (response.IsSuccessStatusCode)
			{
				ColecaoInputModel input = new ColecaoInputModel();
				ColecaoBasicViewModel supercolecao = await response.Content.ReadAsAsync<ColecaoBasicViewModel>();
				input.IdColecaoMaior = supercolecao.Id;
				ViewBag.NomeSupercolecao = supercolecao.Nome;
				return View("Cadastro", input);
			}
			else
				return View("Error");
		}

		[HttpPost]
		public async Task<IActionResult> Cadastrar(ColecaoInputModel input)
		{
			//Salva a foto
			await AppUtil.ProcessarImagem(EnumCategoriaObjeto.Colecao, input, _webHostEnv);

			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			ViewBag.IdUsuario = HttpContext.Session.GetString("usrId");
			HttpClient client = new HelperAPI(HttpContext.Session.GetString("usrToken")).Client;
			HttpResponseMessage response = await client.PostAsJsonAsync($"Colecoes", input);

			if (response.IsSuccessStatusCode)
			{
				ColecaoViewModel colecao = await response.Content.ReadAsAsync<ColecaoViewModel>();
				return Redirect($"Visualizar/{colecao.Id}");
			}
			else
			{
				return RedirectToAction($"Cadastro", input);
			}
		}
	}
}
