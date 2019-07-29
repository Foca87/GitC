using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBidimensionalSuperCompacta.BibliotecaListaBi
{
    class ListaBI
    {
        string[,] listaBi;

        /// <summary>
        /// Inicia a lista bidimensional. Quando se iniciar uma nova instância, já vem com a lista carregada.
        /// </summary>
        public ListaBI()
        {
            listaBi = new string[5, 2];

            CarregaListaBi();
        }

        /// <summary>
        /// Aqui já carregamos ("popular") a lista quando o método é chamado.
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Giomar_{i}";

                Console.WriteLine($"Id: {i} Nome: Giomar_{i}");
            }
        }


        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if (listaBi[i, 0] == idPesquisa)
                {
                    Console.WriteLine("\r\nResultado encontrado com sucesso");
                    Console.WriteLine($"Você pesquisou pelo registro: {listaBi[i,1]}");

                    return; // Sai do método porque já foi encontrado o resultado da pesquisa.
                }
            }

            Console.WriteLine("Nenhum registro encontrado com esse ID");
        }
    }
}
