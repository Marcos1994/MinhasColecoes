using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Models.API
{
	public class UsuarioLoginInputModel
	{
		[Required]
		[EmailAddress]
		public string Login { get; set; }
		[Required(ErrorMessage ="Informe sua senha!")]
		public string Senha { get; set; }
	}
}
