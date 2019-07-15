using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciando um lista de string com array linear
            string[] lista = new string[10]; // aqui definimos a quantidade de posições ("linhas"), com 10 posições(espaços na memória) para salvar as informações.

            // Carregando os valores da lista aonde "i" representa cada espaço que temos disponível
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff"); // DateTime é um tipo do .NET C# que disponibiliza funções relacionadas a datas e horas.
            }

            // Laço de repetição que usamos para varrer nossa lista de maneira mais simples.
            foreach (var item in lista) // "var item" indica uma unidade da nossa lista "in lista".
                Console.WriteLine(item); // Aqui apresentamos a lista na tela.

            Console.ReadKey();
        }
    }
}
