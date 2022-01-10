using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.MinhasColecoesAPI.ViewModels
{
	public class UsuarioViewModel : UsuarioBasicViewModel
	{
		public string Descricao { get; set; }
		public string Foto { get; set; }
		public List<ColecaoBasicViewModel> ColecoesMembro { get; set; } = new List<ColecaoBasicViewModel>();
		public int QuantidadeMembro { get; set; }
		public int QuantidadeDono { get; set; }
		public int QuantidadeParticular { get; set; }
	}
}
