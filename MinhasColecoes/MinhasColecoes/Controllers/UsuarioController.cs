using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhasColecoes.MinhasColecoesAPI.InputModels;
using MinhasColecoes.MinhasColecoesAPI.Services;
using MinhasColecoes.MinhasColecoesAPI.ViewModels;
using MinhasColecoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MinhasColecoes.Controllers
{
	public class UsuarioController : Controller
	{
		public async Task<IActionResult> Index()
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			ViewBag.IdUsuario = HttpContext.Session.GetString("usrId");
			HttpClient client = new HelperAPI(HttpContext.Session.GetString("usrToken")).Client;
			HttpResponseMessage response = await client.GetAsync("Usuario");

			if (response.IsSuccessStatusCode)
			{
				UsuarioViewModel usuario = await response.Content.ReadAsAsync<UsuarioViewModel>();
				return View(usuario);
			}
			else
				return View("Error");
		}

		[HttpGet]
		public IActionResult Login()
		{
			ViewBag.Usuario = HttpContext.Session.GetString("usrNome");
			if (ViewBag.Usuario != null)
				return Redirect("Index");
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(UsuarioLoginInputModel usuarioLogin)
		{
			if (!ModelState.IsValid)
				return View(usuarioLogin);

			HttpClient client = new HelperAPI().Client;
			HttpResponseMessage response = await client.PostAsJsonAsync($"/Usuario/Login", usuarioLogin);
			if (response.IsSuccessStatusCode)
			{
				UsuarioLoginViewModel usuarioLogado = await response.Content.ReadAsAsync<UsuarioLoginViewModel>();

				HttpContext.Session.SetString("usrId", usuarioLogado.Id.ToString());
				HttpContext.Session.SetString("usrNome", usuarioLogado.Nome);
				HttpContext.Session.SetString("usrToken", usuarioLogado.Token);
				ViewBag.Usuario = usuarioLogado.Nome;

				return Redirect("Index");
			}
			else
			{
				return View("Error");
			}
		}
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return Redirect("../");
		}
	}
}
