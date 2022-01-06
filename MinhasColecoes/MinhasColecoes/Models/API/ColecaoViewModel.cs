using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Models.API
{
	public class ColecaoViewModel : ColecaoBasicViewModel
	{
		public UsuarioBasicViewModel Dono { get; set; }
		public ColecaoBasicViewModel ColecaoMaior { get; set; }
		public List<UsuarioBasicViewModel> UsuariosColecao { get; set; }
		public List<ColecaoBasicViewModel> Colecoes { get; set; } = new List<ColecaoBasicViewModel>();
		public List<ItemBasicViewModel> Itens { get; set; } = new List<ItemBasicViewModel>();
	}
}
