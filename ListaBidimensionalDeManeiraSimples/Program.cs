using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBidimensionalDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[5, 2]; // Criando o array com 5 linhas e 2 colunas (bidimensional).

            CarregaInformacoesEListaElasEmTela(ref listaDeNome); // Aqui o "ref" faz referência para que a variável receba a "atualização" dos valores depois que o método for executado.

            Console.ReadKey();

            Console.WriteLine("Informe ID a ser pesquisado: ");

            PesquisandoInformacoesNaLista(listaDeNome, Console.ReadLine());

            Console.ReadKey();
        }

        /// <summary>
        /// Método que carrega as informações dentro da lista criado no método "Main" e as apresenta na tela.
        /// </summary>
        /// <param name="arrayBi"></param>
        public static void CarregaInformacoesEListaElasEmTela(ref string[,] arrayBi)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++) // Para arrays bidimensionais deve-se utilizar o GetLength informando entre () qual a coluna que deve ter sua quantidade de linhas contadas.
            {
                arrayBi[i, 0] = i.ToString(); // Carregando (assinando, ou atribuindo) o que podemos chamar de "ID" para identificar nosso registro único.
                arrayBi[i, 1] = $"Felipe_{i+10}"; // Adicionando uma informação extra para preencher o campo na segunda coluna.
            }

            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}"); // Formatado como string para apresentar os dados.
            }
        }

        /// <summary>
        /// Método que faz a busca no array comparando o identificador único informado pelo usuário com o que existe dentro do array.
        /// </summary>
        /// <param name="arrayBi">Coleção de informações.</param>
        /// <param name="pId">Identificador único.</param>
        public static void PesquisandoInformacoesNaLista(string[,] arrayBi, string pId)
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
