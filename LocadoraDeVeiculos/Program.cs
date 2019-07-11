using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos
{
    class Program
    {
        static string[,] baseDeVeiculos;

        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            MostrarSejaBemVindo();

            if(MenuInicial() == 1)
            {
                
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Método que carrega a base de dados.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeVeiculos = new string[2, 3]
            {
                {"Fiesta","2018","sim" },
                { "Punto","2019","não"}
            };
        }

        /// <summary>
        /// Método que faz a listagem da base de dados por linha.
        /// </summary>
        public static void ListaBaseDeDados()
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
                Console.WriteLine($"Veículo: {baseDeVeiculos[i, 0]} Ano: {baseDeVeiculos[i, 1]} Disponível? {baseDeVeiculos[i, 2]}");
        }

        /// <summary>
        /// Método que apresenta as "Boas Vindas" do sistema ao usuário.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*|             Locadora de Veículos              |*");
            Console.WriteLine("*|        Sistema de locação de Veículos         |*");
            Console.WriteLine("*| Desenvolvido pelos Ratos Motoqueiros de Marte |*");
            Console.WriteLine("***************************************************");
        }

        /// <summary>
        /// Método que apresenta o Menu Inicial e opções para escolha.
        /// </summary>
        /// <returns>Retorna a opção do menu escolhida como um número do tipo inteiro.</returns>
        public static int MenuInicial()
        {
            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Locar um Veículo");
            Console.WriteLine("0 - Sair do sistema");
            Console.WriteLine("Digite o número da opção desejada:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        
        public static void MostrarMenuLocacao()
        {
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Menu - Locação de Veículos");
            ListaBaseDeDados();
            Console.WriteLine("Digite o veículo que deseja locar:");
            Console.ReadLine();
        }
    }
}
