using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Models.API
{
	public class ColecaoInputModel
	{
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public bool Publica { get; set; }
		public string Foto { get; set; }
	}
}
