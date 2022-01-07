using Microsoft.AspNetCore.Http;
using MinhasColecoes.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.MinhasColecoesAPI.InputModels
{
	public class ColecaoInputModel : IFotoModel
	{
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public bool Publica { get; set; }
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
