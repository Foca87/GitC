using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static string[,] listaDeChamada;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            MostrarSejaBemVindo();

            ListaBaseDeDados();
            Console.ReadKey();
        }

        /// <summary>
        /// Método que apresenta as "Boas Vindas" do sistema ao usuário.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*|          Imprime a Lista de Chamada           |*");
            Console.WriteLine("*|                                               |*");
            Console.WriteLine("*|        Desenvolvido por Christian Buhr        |*");
            Console.WriteLine("***************************************************");
        }

        /// <summary>
        /// Método que carrega a base de dados.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            listaDeChamada = new string[20, 3]
            {
                {"João", "15", "Masculino" },
                {"Maria", "16", "Feminino" },
                {"Fernanada", "14", "Feminino" },
                {"Isabela", "15", "Feminino" },
                {"Jorge", "14", "Masculino" },
                {"Iuri", "16", "Masculino" },
                {"Bruno", "13", "Masculino" },
                {"Gabriele", "16", "Feminino" },
                {"Isabel", "13", "Feminino" },
                {"Gabriel", "12", "Masculino" },
                {"Adriana", "17","Feminino" },
                {"Eduardo", "12", "Masculino" },
                {"Flávia", "17", "Feminino" },
                {"Vilson", "18", "Masculino" },
                {"Amanda", "19", "Feminino" },
                {"Nicolas", "19", "Masculino" },
                {"Vitor", "11", "Masculino" },
                {"Aline", "11", "Feminino" },
                {"Bruna", "18", "Feminino" },
                {"Marta", "13", "Feminino" }
            };
        }

        /// <summary>
        /// Método que faz a listagem da base de dados por linha sem informar a disponibilidade.
        /// </summary>
        public static void ListaBaseDeDados()
        {
            for (int i = 0; i < listaDeChamada.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {listaDeChamada[i, 0]} | Idade: {listaDeChamada[i, 1]} | Sexo: {listaDeChamada[i, 2]}");
            }
        }
    }
}
