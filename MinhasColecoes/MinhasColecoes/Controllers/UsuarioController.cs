using Microsoft.AspNetCore.Mvc;
using MinhasColecoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Controllers
{
	public class UsuarioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
