using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhasColecoes.MinhasColecoesAPI.InputModels;
using MinhasColecoes.MinhasColecoesAPI.Services;
using MinhasColecoes.MinhasColecoesAPI.ViewModels;
using MinhasColecoes.Models;
using MinhasColecoes.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MinhasColecoes.Controllers
{
	public class ItemController : Controller
	{
		private readonly IWebHostEnvironment _webHostEnv;

		public ItemController(IWebHostEnvironment webHostEnv)
		{
			_webHostEnv = webHostEnv;
		}

		public IActionResult Visualizar()
		{
			return View();
		}

		[HttpGet]
		public IActionResult CadastroIndividual()
		{
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> CadastroMultiplo(int id)
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			ViewBag.IdUsuario = HttpContext.Session.GetString("usrId");
			HttpClient client = new HelperAPI(HttpContext.Session.GetString("usrToken")).Client;
			HttpResponseMessage response = await client.GetAsync($"Colecoes/{id}/Genealogia");

			if (!response.IsSuccessStatusCode)
				return View("Error");

			ColecaoGenealogiaViewModel genealogia = await response.Content.ReadAsAsync<ColecaoGenealogiaViewModel>();

			string genealogiaText = "";
			do
			{
				genealogiaText  = $"{genealogia.Nome} {genealogiaText}";
				genealogia = genealogia.ColecaoPai;
			} while (genealogia != null);

			MultiplosItensInputModel input = new MultiplosItensInputModel();
			input.IdColecao = id;
			ViewBag.NomeGenealogia = genealogiaText;
			return View(input);
		}

		[HttpPost]
		public IActionResult CadastrarIndividual()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CadastrarMultiplos(MultiplosItensInputModel inputs)
		{
			if(inputs.FotosImg.Count() == 0)
				return View("Error");

			int idUsuario = Convert.ToInt32(HttpContext.Session.GetString("usrId"));
			List<ItemInputModel> itens = new List<ItemInputModel>();

			//Gero os itens InputModel
			foreach(IFormFile f in inputs.FotosImg)
			{
				if(inputs.GetNome(f).Length >= 3)
					itens.Add(new ItemInputModel() {
						Codigo = inputs.GetCodigo(f),
						Comentario = "",
						Descricao = "",
						Foto = "",
						FotoImg = f,
						IdColecao = inputs.IdColecao,
						IdUsuario = idUsuario,
						Nome = inputs.GetNome(f),
						Relacao = inputs.GetRelacao(f)
					});
			}

			//Salvo as fotos
			for (int i = 0; i < itens.Count; i++)
				await AppUtil.ProcessarImagem(EnumCategoriaObjeto.Item, itens[i], _webHostEnv);

			List<ItemInputModel> itensNaoCadastrados = new List<ItemInputModel>();
			List<ColecaoBasicViewModel> itensCadastrados = new List<ColecaoBasicViewModel>();
			HttpClient client = new HelperAPI(HttpContext.Session.GetString("usrToken")).Client;
			HttpResponseMessage response;

			for (int i = 0; i < itens.Count; i++)
			{
				response = await client.PostAsJsonAsync($"Itens/?idColecao={inputs.IdColecao}", itens[i]);

				if (response.IsSuccessStatusCode)
					itensCadastrados.Add(await response.Content.ReadAsAsync<ColecaoBasicViewModel>());
				else
					itensNaoCadastrados.Add(itens[i]);
			}

			return Redirect($"../Colecao/Visualizar/{inputs.IdColecao}");
		}
	}
}
