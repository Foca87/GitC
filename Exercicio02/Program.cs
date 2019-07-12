using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static string[] receitaDeBolo;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            MostrarSejaBemVindo();

            Console.WriteLine("Pressione qualquer tecla para iniciar a leitura da receita.");
            Console.ReadKey();
            LerReceita();
        }

        /// <summary>
        /// Método que apresenta as "Boas Vindas" do sistema ao usuário.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*|          Leitor de Receitas de Bolo           |*");
            Console.WriteLine("*|                                               |*");
            Console.WriteLine("*|        Desenvolvido por Christian Buhr        |*");
            Console.WriteLine("***************************************************");
        }

        /// <summary>
        /// Método que carrega a base de dados.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            receitaDeBolo = new string[6]
            {
               "1 - Pegue o açúcar. leite e a manteiga.",
               "2 - Misture e coloque na batedeira para misturar.",
               "3 - Pegue a calda de chocolate.",
               "4 - Leve a calda ao fogão e aqueça levemente.",
               "5 - Coloque a massa do bolo na forma e adicione a calda de chocolate por cima.",
               "6 - Leve a geladeira."
            };
        }

        /// <summary>
        /// Método que apresenta a receita na tela.
        /// </summary>
        public static void LerReceita()
        {
            for (int i = 0; i < receitaDeBolo.Length; i++)
            {
                Console.Clear();
                MostrarSejaBemVindo();

                Console.WriteLine(receitaDeBolo[i]);
                Console.WriteLine("Pressione qualquer tecla para continuar ao próximo passo.");
                Console.ReadKey();
            }
        }
    }
}
