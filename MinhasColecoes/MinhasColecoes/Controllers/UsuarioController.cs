using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhasColecoes.Helper;
using MinhasColecoes.Models;
using MinhasColecoes.Models.API;
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
	}
}
