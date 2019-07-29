using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBidimensionalDeManeiraSimplesComClass.Mostrar
{
    class MostrarLista
    {
        /// <summary>
        /// Método que faz a busca no array comparando o identificador único informado pelo usuário com o que existe dentro do array.
        /// </summary>
        /// <param name="arrayBi">Coleção de informações.</param>
        /// <param name="pId">Identificador único.</param>
        public void PesquisandoInformacoesNaLista(string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                if (arrayBi[i, 0] == pId) // Realiza comparação dos mesmos tipos.
                {
                    Console.WriteLine($"Informação escolhida: ID: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
                    return; // Retorna vazio por ser um método void. Finalizamos a execução do método pois um resultado já foi encontrado.
                }
            }

            Console.WriteLine("Infelizmente a busca pelo ID não encontrou nada."); // Apresenta esta informação caso nenhum registro seja encontrado.
        }
    }
}
