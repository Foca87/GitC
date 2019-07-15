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

            int opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    MostrarMenuLocacao();

                if (opcaoMenu == 2)
                    MostrarMenuDevolucao();

                opcaoMenu = MenuPrincipal();
            }

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
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Locar um livro");
            Console.WriteLine("2 - Devolver um livro");
            Console.WriteLine("3 - Sair do sistema");
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
        public static bool? PesquisaLivroParaLocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDeLivros[i,0]))
                {
                    Console.WriteLine($"O livro {baseDeLivros[i,0]} " +
                        $"pode ser locado? {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }

            Console.WriteLine("Nenhum livro encontrado. Deseja realizar a busca novamente?");
            Console.WriteLine("Digite o número da opção desejada: 1 - SIM | 2 - NÃO");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do livro a ser pesquisado: ");
                nomeLivro = Console.ReadLine();

                return PesquisaLivroParaLocacao(nomeLivro);
            }

            return null;
        }

        /// <summary>
        /// Método que loca o livro de acordo com o parâmetro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do Livro a ser locado</param>
        public static void LocarLivro(string nomeLivro, bool locar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = locar? "não" : "sim";
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Livro atualizado com sucesso!");
        }

        /// <summary>
        /// Método que carrega a o conteúdo inicial da aplicação - Menu de locação de Livros.
        /// </summary>
        public static void MostrarMenuLocacao()
        {
            MostrarMenuInicialLivros("Locar um livro");

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaLocacao(nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();

                Console.WriteLine("Você deseja locar o livro? Para SIM digite 1. Para NÂO digite 0.");

                LocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "1");

                Console.WriteLine("\n\nListagem de livros");

                MostrarListaDeLivros();
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Método que mostra a lista de livros atualizada.
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponível: {baseDeLivros[i, 1]}");
        }

        /// <summary>
        /// Método que carrega a o conteúdo inicial da aplicação - Menu de devolução de Livros.
        /// </summary>
        public static void MostrarMenuDevolucao()
        {
            MostrarMenuInicialLivros("Devolver um livro");

            //MostrarListaDeLivros();

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaLocacao(nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                MostrarSejaBemVindo();

                Console.WriteLine("Você deseja devolver o livro? Para SIM digite 1. Para NÂO digite 0.");

                LocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                Console.WriteLine("\n\nListagem de livros");

                MostrarListaDeLivros();
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Método que apresenta o menu inicial das opções do que fazer com os livros.
        /// </summary>
        /// <param name="operacao"></param>
        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação: ");
        }

        /// <summary>
        /// Método que compara duas strings deixando em letra minúscula e removendo espaços vazios.
        /// </summary>
        /// <param name="primeiro">Primeira string a ser comparada.</param>
        /// <param name="segundo">Segunda string a ser comparada.</param>
        /// <returns>Retorna verdadeiro quando ambas as strings são iguais.</returns>
        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "") == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
        }
    }
}