using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Util
{
	public interface IFotoModel
	{
		public string GetNome();
		public IFormFile GetArquivo();
		public void SetNomeFoto(string nomeFoto);
	}
}
