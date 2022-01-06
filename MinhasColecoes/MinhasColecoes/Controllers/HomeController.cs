using Microsoft.AspNetCore.Http;
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
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			if (ViewBag.Usuario != null)
				return Redirect("../Usuario/Index");
			return View();
		}

		[HttpGet]
		public IActionResult Login()
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			if (ViewBag.Usuario != null)
				return Redirect("../Usuario/Index");
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

				HttpContext.Session.SetString("usrId", usuarioLogado.Id.ToString());
				HttpContext.Session.SetString("usrNome", usuarioLogado.Nome);
				HttpContext.Session.SetString("usrToken", usuarioLogado.Token);
				ViewBag.Usuario = usuarioLogado.Nome;

				return Redirect("../Usuario/Index");
			}
			else
			{
				return View("Error");
			}
		}
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return View("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
