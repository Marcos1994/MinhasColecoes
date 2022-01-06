using MinhasColecoes.Models.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Models.API
{
	public class ItemBasicViewModel
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Codigo { get; set; }
		public string Descricao { get; set; }
		public bool Original { get; set; }
		public int? IdOriginal { get; set; }
		public ItemBasicViewModel ItemOriginal { get; set; }
		public EnumRelacaoUsuarioItem Relacao { get; set; }
		public string Comentario { get; set; }

		public string CodigoNome
		{ get { return ((Codigo != null && Codigo.Length > 0) ? $"{Codigo} - " : "") + Nome; } }
	}
}
