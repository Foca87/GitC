using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaOrganizada.BibliotecaLista
{
    public class FuncoesLista
    {
        string[] listaDeDados;

        public FuncoesLista()
        {
            listaDeDados = new string[10];

            PopularLista();
        }

        public void PopularLista()
        {
            for (int i = 0; i < listaDeDados.Length; i++)
            {
                listaDeDados[i] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff");
            }
        }

        public void ApagarLista()
        {
            for (int i = 0; i < listaDeDados.Length; i++)
            {
                listaDeDados[i] = string.Empty;
            }
        }

        public void MostrarLista()
        {
            for (int i = 0; i < listaDeDados.Length; i++)
            {
                Console.WriteLine($"Valor da célula: {listaDeDados[i]}");
            }

            Console.ReadKey();
        }

        public void MudarTamanho (int novoTamanho)
        {
            listaDeDados = new string[novoTamanho];
        }
    }
}
