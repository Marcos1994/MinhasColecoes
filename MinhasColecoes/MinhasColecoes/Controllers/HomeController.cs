using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhasColecoes.Helper;
using MinhasColecoes.Models;
using MinhasColecoes.Models.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MinhasColecoes.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(UsuarioLoginInputModel usuarioLogin)
		{
			if(!ModelState.IsValid)
				return View(usuarioLogin);

			HttpClient client = new HelperAPI().Client;
			HttpResponseMessage response = await client.PostAsJsonAsync($"/Usuario/Login", usuarioLogin);
			if(response.IsSuccessStatusCode)
			{
				UsuarioLoginViewModel usuarioLogado = await response.Content.ReadAsAsync<UsuarioLoginViewModel>();

				TempData["usrId"] = usuarioLogado.Id;
				TempData["usrNome"] = usuarioLogado.Nome;
				TempData["usrToken"] = usuarioLogado.Token;

				return View("../Usuario/Index");
			}
			else
			{
				return View("../Home");
			}
		}
		public IActionResult Logout()
		{
			TempData["usrId"] = null;
			TempData["usrNome"] = null;
			TempData["usrToken"] = null;
			return View("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
