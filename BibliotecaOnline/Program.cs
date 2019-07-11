using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            MostrarSejaBemVindo();

            if (MenuInicial() == 1)
                MostrarMenuLocacao();
            
            Console.ReadKey();
        }
        /// <summary>
        /// Método que apresenta as "Boas Vindas" do sistema ao usuário.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine(" ***********************************************");
            Console.WriteLine("|              Biblioteca On-line               |");
            Console.WriteLine("|         Sistema de locação de livros          |");
            Console.WriteLine("| Desenvolvido pelos Ratos Motoqueiros de Marte |");
            Console.WriteLine(" ***********************************************");
        }

        /// <summary>
        /// Método que mostra o menu inicial e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido como um tipo inteiro.</returns>
        public static int MenuInicial()
        {
            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Locar um livro");
            Console.WriteLine("2 - Sair do sistema");
            Console.WriteLine("Digite o número desejado:");

            // Abaixo 3 opções para ler o input do usuário.
            //var opcao = (int)Console.ReadKey().KeyChar;                       // Lê o número digitado e aponta para tabela ASC e converte para inteiro.
            //var opcao = Console.ReadKey().KeyChar.ToString();                 // Lê apenas o número digitado sem conversão.
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);  // Lê o caracter digita e converte o char para int.

            return opcao;
        }

        /// <summary>
        /// Método que carrega a base de dados.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno", "sim" },
                {"O grande", "não" }
            };
        }

        /// <summary>
        /// Método que retorna se um livro pode ser locado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado.</param>
        /// <returns>Retorna verdadeiro caso o livro esteja disponível para locação.</returns>
        public static bool PesquisaLivroParaLocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro {nomeLivro} " +
                        $"pode ser locado? {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }
            return false;
        }

        /// <summary>
        /// Método que loca o livro de acordo com o parâmetro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do Livro a ser locado</param>
        public static void LocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "não";
            }
        }

        /// <summary>
        /// Método que carrega a o conteúdo inicial da aplicação - Menu 1.
        /// </summary>
        public static void MostrarMenuLocacao()
        {
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Menu - Locação de livros");
            Console.WriteLine("Digite o nome do livro a ser locado: ");

            var nomedolivro = Console.ReadLine();
            if (PesquisaLivroParaLocacao(nomedolivro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja locar o livro? Para SIM digite 1. Para NÂO digite 0.");

                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    LocarLivro(nomedolivro);
                    Console.WriteLine("\nLivro locado com sucesso!");
                }

                Console.WriteLine("\nLocação de livro cancelada.");
                Console.WriteLine("\n\nListagem de livros");

                for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                    Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponível: {baseDeLivros[i, 1]}");
            }
        }
    }
}