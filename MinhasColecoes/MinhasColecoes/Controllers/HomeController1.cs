using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhasColecoes.MinhasColecoesAPI.InputModels;
using MinhasColecoes.Models;
using MinhasColecoes.Util;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Controllers
{
	public class HomeController1 : Controller
	{
		private readonly IWebHostEnvironment _webHostEnv;

		public HomeController1(IWebHostEnvironment webHostEnv)
		{
			_webHostEnv = webHostEnv;
		}

		[HttpPost]
		public async Task<IActionResult> CadastrarMultiplos(MultiplosItensInputModel inputs)
		{
			if (inputs.FotosImg.Count() == 0)
				return View("Error");


			foreach (IFormFile obj in inputs.FotosImg)
			{//Verifica se o arquivo não é nulo

				//Copia a imagem para a memoria
				MemoryStream ms = new MemoryStream();
				await obj.CopyToAsync(ms);

				//Carrega o fluxo em memória para o objeto de processamento de imagem
				ms.Position = 0;
				Image img = await Image.LoadAsync(ms);

				//Converte a imagem para jpeg e recarrega ela
				JpegEncoder jpegEnc = new JpegEncoder();
				jpegEnc.Quality = 100;
				img.SaveAsJpeg(ms, jpegEnc);
				ms.Position = 0;
				img = await Image.LoadAsync(ms);

				//Encerro o fluxo de memória
				ms.Close();
				ms.Dispose();

				int tamanhoMaximo = 900;

				//Redimensiono a imagem
				if (img.Size().Width > tamanhoMaximo || img.Size().Height > tamanhoMaximo)
				{
					ResizeOptions resize = new ResizeOptions()
					{
						Mode = ResizeMode.Max,
						Size = new Size(tamanhoMaximo, tamanhoMaximo)
					};

					img.Mutate(i => i.Resize(resize));
				}

				//Defino e seto o nome do arquivo sem a extensão e sufixos
				char separador = '-';
				string[] palavras = obj.FileName.Split(separador);
				for (int i = 0; i < palavras.Length; i++)
					palavras[i] = palavras[i][0].ToString().ToUpper() + palavras[i].Substring(1);

				int colecaoCount = 2;
				string colecao = "";
				for (int i = 0; i < colecaoCount; i++)
				{
					if (i > 0) colecao += " ";
					colecao += palavras[palavras.Length - (2 + colecaoCount-i)];
				}
				string nome = string.Join(' ', palavras, 0, palavras.Length-(2+ colecaoCount));
				string codigo = (Convert.ToInt32( (palavras[palavras.Length - 1].Split('.'))[0] )).ToString("000");

				//Salvo a imagem
				var diretorio = Path.Combine(_webHostEnv.WebRootPath, $"img\\fotos\\{colecao}", $"{codigo};{nome}" + ".jpg");
				await img.SaveAsync(diretorio);
			}


			return View("../Home/Index");
		}
	}
}
