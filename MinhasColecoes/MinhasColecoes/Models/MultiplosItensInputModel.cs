using Microsoft.AspNetCore.Http;
using MinhasColecoes.MinhasColecoesAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Models
{
	public class MultiplosItensInputModel
	{
		public int IdColecao { get; set; }
		public bool ComCodigo { get; set; }
		public bool ComRelacao { get; set; }
		public List<IFormFile> FotosImg { get; set; } = new List<IFormFile>();

		public string GetNome(IFormFile arquivo)
		{
			int posicao = 0;
			posicao += (ComCodigo) ? 1 : 0;
			posicao += (ComRelacao) ? 1 : 0;

			string[] palavras = arquivo.FileName.ToLower().Split(' ');
			if(palavras.Length < posicao)
				return "";

			string nome = string.Join(' ', palavras, posicao, palavras.Length - posicao);
			palavras = nome.Split('.');

			if(palavras.Length>0)
				nome = string.Join(' ', palavras, 0, palavras.Length-1);

			return nome;
		}
		public string GetCodigo(IFormFile arquivo)
		{
			if(!ComCodigo)
				return "";

			string[] palavras = arquivo.FileName.Split(' ');
			if (palavras.Length > 1)
				return palavras[0];

			return "";
		}
		public EnumRelacaoUsuarioItem GetRelacao(IFormFile arquivo)
		{
			if (!ComRelacao)
				return EnumRelacaoUsuarioItem.NaoPossuo;

			int posicao = (ComCodigo && ComRelacao) ? 1 : 0;
			string[] palavras = arquivo.FileName.ToUpper().Split(' ');
			if(palavras.Length <= posicao)
				return EnumRelacaoUsuarioItem.NaoPossuo;

			switch (palavras[posicao])
			{
				case "D":
					return EnumRelacaoUsuarioItem.Desejo;
				case "C":
					return EnumRelacaoUsuarioItem.AguardandoRecebimento;
				case "P":
					return EnumRelacaoUsuarioItem.Possuo;
				case "T":
					return EnumRelacaoUsuarioItem.Trocar;
				case "V":
					return EnumRelacaoUsuarioItem.Vender;
				default:
					return EnumRelacaoUsuarioItem.NaoPossuo;
			}
		}
	}
}
