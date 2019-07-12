using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {                        
            MostrarSejaBemVindo();

            Console.WriteLine("Por favor, qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Por favor, informe a sua idade: ");
            int.TryParse(Console.ReadLine().ToString(), out int idade);

            if (idade > 18)
                Console.WriteLine($"Parabéns {nome}! Você tem mais de 18 anos e já pode consumir bebidas alcoólicas.");
            else
                Console.WriteLine("Você ainda não pode consumir bebidas alcoólicas.");

            Console.ReadKey();
        }

        /// <summary>
        /// Método que apresenta as "Boas Vindas" do sistema ao usuário.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*|              Teste de maioridade              |*");
            Console.WriteLine("*|              Você já pode beber?              |*");
            Console.WriteLine("*|        Desenvolvido por Christian Buhr        |*");
            Console.WriteLine("***************************************************");
        }
    }
}
