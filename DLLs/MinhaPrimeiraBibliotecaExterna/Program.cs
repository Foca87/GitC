using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaArquivos = new GetFiles();

            Console.WriteLine("Retorna os arquivos da pasta Meus Documentos");
            foreach (var retorno in listaArquivos.RetornaArquivosDoMeuDocumentos())
                Console.WriteLine(retorno);

            Console.WriteLine("Retorna os arquivos da pasta Imagens");
            foreach (var retorno in listaArquivos.RetornaArquivosImagesFiles())
                Console.WriteLine(retorno);

            Console.WriteLine("Retorna os arquivos da pasta GIT");
            if (listaArquivos.RetornaArquivosGit() != null)
                foreach (var retorno in listaArquivos.RetornaArquivosGit())
                    Console.WriteLine(retorno);
            else
                Console.WriteLine("A pasta GIT não existe!");

            Console.ReadKey();
        }
    }
}
