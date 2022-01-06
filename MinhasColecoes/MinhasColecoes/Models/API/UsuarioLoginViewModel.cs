using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Models.API
{
	public class UsuarioLoginViewModel : UsuarioBasicViewModel
	{
		public string Login { get; set; }
		public string Token { get; set; }
	}
}
