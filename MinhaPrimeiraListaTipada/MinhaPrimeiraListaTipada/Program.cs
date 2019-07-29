using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo do Felipe
            /*
            List<Lanche> minhaLista = new List<Lanche>(); //O indicador <T> o tipo da minha lista com isso temos uma lista de lanches.

            minhaLista.Add(new Lanche()
            {
                Nome = "Pão de queijo", //Adiciona um pão de queijo na lista.
                Quantidade = 9,
                Valor = 1.85
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinho de Soya + Refri Bônus: Gastrite",
                Quantidade = 3,
                Valor = 7.50
            });

            foreach (Lanche item in minhaLista) //Aqui ando pela minha lista para poder apresentar em tela os valores. 'item in' signigica que ele já é um índice da minha lista.
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");

            //minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2)); // Expressão lambda.

            //var menuIten = (from item in minhaLista where item.Quantidade == 3 select item).ToList<Lanche>(); //Retorna coleções.

            Console.WriteLine("Removendo item");

            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 3)
                {
                    minhaLista.Remove(item);
                    break;
                }
            }

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");
            */
            #endregion

            List<Lanche> listaDeLanches = new List<Lanche>(); //Inicializado a lista.

            for (int i = 0; i < 5; i++)
            {                
                listaDeLanches.Add(new Lanche()
                {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                });
            }

            foreach (Lanche item in listaDeLanches)
                Console.WriteLine($"Nome: {item.Nome} | Quantidade: {item.Quantidade} | Valor: {item.Valor}");

            Console.ReadKey();
        }

        /// <summary>
        /// Método que mostra uma interface legal para adicionar os valores.
        /// </summary>
        /// <param name="nome">Nome do campo que irá retornar o valor.</param>
        /// <returns>Retornar uma string com o valor.</returns>
        public static string RetornaValores(string campo)
        {
            Console.WriteLine($"Informe o valor para o campo: {campo}");
            return Console.ReadLine();
        }
    }
}
