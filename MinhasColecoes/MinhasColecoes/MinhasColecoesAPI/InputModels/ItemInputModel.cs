using Microsoft.AspNetCore.Http;
using MinhasColecoes.MinhasColecoesAPI.Enums;
using MinhasColecoes.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.MinhasColecoesAPI.InputModels
{
	public class ItemInputModel : IFotoModel
	{
		public int IdColecao { get; set; }
		public string Nome { get; set; }
		public int IdUsuario { get; set; }
		public string Codigo { get; set; }
		public string Descricao { get; set; }
		public EnumRelacaoUsuarioItem Relacao { get; set; }
		public string Comentario { get; set; }
		public string Foto { get; set; }
		public IFormFile? FotoImg { get; set; }

		public IFormFile GetArquivo()
		{
			return FotoImg;
		}

		public string GetNome()
		{
			return Nome;
		}

		public void SetNomeFoto(string nomeFoto)
		{
			Foto = nomeFoto;
		}
	}
}
