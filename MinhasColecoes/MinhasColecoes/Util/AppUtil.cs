using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasColecoes.Util
{
	public static class AppUtil
	{
		public static async Task ProcessarImagem(EnumCategoriaObjeto categoria, IFotoModel obj, IWebHostEnvironment webHostEnv)
		{
			//Copia a imagem para a memoria
			MemoryStream ms = new MemoryStream();
			await obj.GetArquivo().CopyToAsync(ms);

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

			//Redimensiono a imagem
			if(img.Size().Width > 900 || img.Size().Height > 900)
			{
				ResizeOptions resize = new ResizeOptions()
				{
					Mode = ResizeMode.Max,
					Size = new Size(900, 900)
				};

				img.Mutate(i => i.Resize(resize));
			}

			//Defino e seto o nome do arquivo sem a extensão e sufixos
			string nomeArquivo = $"{obj.GetNome().Trim()}_{DateTime.Now.ToString("yyyyMMddHHmmssFFF")}";
			nomeArquivo.Replace(' ', '_');
			obj.SetNomeFoto(nomeArquivo);

			//Salvo a imagem
			var diretorio = Path.Combine(webHostEnv.WebRootPath, $"img\\fotos\\{categoria.ToString()}", nomeArquivo + ".jpg");
			await img.SaveAsync(diretorio);
		}
	}
}
