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

            for (int i = 0; i < listaDeNome.GetLength(0); i++) // Para arrays bidimensionais deve-se utilizar o GetLength informando entre () qual a coluna que deve ter sua quantidade de linhas contadas.
            {
                listaDeNome[i, 0] = i.ToString(); // Carregando (assinando, ou atribuindo) o que podemos chamar de "ID" para identificar nosso registro único.
                listaDeNome[i, 1] = $"Felipe_{i}"; // Adicionando uma informação extra para preencher o campo na segunda coluna.
            }

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {listaDeNome[i,0]} - Nome: {listaDeNome[i,1]}"); // Formatado como string para apresentar os dados.
            }

            Console.ReadKey();
        }
    }
}
