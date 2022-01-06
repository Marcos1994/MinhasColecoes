using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Models.API
{
	public class UsuarioViewModel : UsuarioBasicViewModel
	{
		public string Descricao { get; set; }
		public string Foto { get; set; }
		public List<ColecaoBasicViewModel> ColecoesDono { get; set; } = new List<ColecaoBasicViewModel>();
		public List<ColecaoBasicViewModel> ColecoesMembro { get; set; } = new List<ColecaoBasicViewModel>();
	}
}
