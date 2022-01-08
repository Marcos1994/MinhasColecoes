using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.MinhasColecoesAPI.ViewModels
{
	public class ColecaoGenealogiaViewModel
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int IdDono { get; set; }
		public bool Publica { get; set; }
		public ColecaoGenealogiaViewModel ColecaoPai { get; set; }
	}
}
