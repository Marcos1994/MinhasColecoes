using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.MinhasColecoesAPI.ViewModels
{
	public class ColecaoBasicViewModel
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public string Foto { get; set; }
		public bool Publica { get; set; }
		public int IdDono { get; set; }
		public int? IdColecaoMaior { get; set; }
		public int QuantidadeMembros { get; set; }
		public int QuantidadeSubcolecoes { get; set; }
		public bool UsuarioParticipa { get; set; }
	}
}
