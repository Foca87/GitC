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
                        
            switch (MenuInicial())
            {
                case 1:
                    MenuLocacao();
                    break;
                case 2:
                    MenuDevolucao();
                    break;
                case 3:
                    ListaBaseDeDadosCompleta();
                    break;
                default:                        
                    break;
            }
            Console.ReadKey();
        }

        #region Métodos
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
        /// Método que faz a listagem da base de dados por linha sem informar a disponibilidade.
        /// </summary>
        public static void ListaBaseDeDados()
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
                Console.WriteLine($"Veículo: {baseDeVeiculos[i, 0]} Ano: {baseDeVeiculos[i, 1]}");                
        }

        /// <summary>
        /// Método que faz a listagem da base de dados por linha.
        /// </summary>
        public static void ListaBaseDeDadosCompleta()
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
            Console.WriteLine("2 - Devolver um Veículo");
            Console.WriteLine("3 - Relatório de Veículos");
            Console.WriteLine("0 - Sair do sistema");
            Console.WriteLine("Digite o número da opção desejada:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        /// <summary>
        /// Método que carrega o menu de Locação - Menu opção 1.
        /// </summary>
        public static void MenuLocacao()
        {
            SubMenuInicial("Locação de Veículos");
            ListaBaseDeDados();

            Console.WriteLine("Digite o veículo que deseja locar:");
            var modeloveiculo = Console.ReadLine();

            if (PesquisaVeiculoParaLocacao(modeloveiculo))
            {
                Console.WriteLine("Você deseja locar o veículo? Para SIM digite 1. Para NÂO digite 0.");

                AtualizarVeiculo(modeloveiculo, Console.ReadKey().KeyChar.ToString() == "1");
                Console.WriteLine("\nVeículo locado com sucesso!");
                
                Console.WriteLine("\n\nListagem de Veículos");

                ListaBaseDeDadosCompleta();
            }
        }

        /// <summary>
        /// Método que carrega o menu de Devolução - Menu opção 2.
        /// </summary>
        public static void MenuDevolucao()
        {
            SubMenuInicial("Devolução de Veículos");

            ListaBaseDeDados();

            Console.WriteLine("Digite o veículo que deseja devolver:");

            var modeloveiculo = Console.ReadLine();

            if (PesquisaVeiculoParaDevolucao(modeloveiculo))
            {
                
                Console.WriteLine("Você deseja devolver o veículo? Para SIM digite 1. Para NÂO digite 0.");

                AtualizarVeiculo(modeloveiculo, Console.ReadKey().KeyChar.ToString() == "0");
                Console.WriteLine("\nVeículo devolvido com sucesso!");

                Console.WriteLine("\n\nListagem de Veículos");

                ListaBaseDeDadosCompleta();
            }
        }

        /// <summary>
        /// Método que atualiza a disponibilidade do veículo.
        /// </summary>
        /// <param name="modeloVeiculo">Modelo do veículo a ser atualizado.</param>
        public static void AtualizarVeiculo(string modeloVeiculo, bool atualizar)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (modeloVeiculo == baseDeVeiculos[i, 0])
                    baseDeVeiculos[i, 2] = atualizar ? "não" : "sim";
            }
        }

        /// <summary>
        /// Método que retorna se um veículo pode ser locado. 
        /// </summary>
        /// <param name="modeloVeiculo"></param>
        /// <returns>Retorna verdadeiro caso o veículo esteja disponível para locação.</returns>
        public static bool PesquisaVeiculoParaLocacao(string modeloVeiculo)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (modeloVeiculo == baseDeVeiculos[i,0])
                {
                    Console.WriteLine($"O {modeloVeiculo} " +
                        $"fabricado em {baseDeVeiculos[i,1]} " +
                        $"pode ser locado? {baseDeVeiculos[i, 2]}");

                    return baseDeVeiculos[i, 2] == "sim";
                }
            }
            return false;
        }       

        /// <summary>
        /// Método que retorna se um veículo pode ser devolvido. 
        /// </summary>
        /// <param name="modeloVeiculo"></param>
        /// <returns>Retorna verdadeiro caso seja possível devolver o veículo.</returns>
        public static bool PesquisaVeiculoParaDevolucao(string modeloVeiculo)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (modeloVeiculo == baseDeVeiculos[i, 0] && baseDeVeiculos[i,2] == "não")
                {
                    Console.WriteLine($"O {baseDeVeiculos[i, 0]} " +
                         $"fabricado em {baseDeVeiculos[i, 1]} " +
                         $"pode ser devolvido.");

                    return baseDeVeiculos[i, 2] == "não";
                }

                if (modeloVeiculo == baseDeVeiculos[i, 0] && baseDeVeiculos[i, 2] == "sim")
                {
                    Console.WriteLine($"O {baseDeVeiculos[i, 0]} " +
                        $"fabricado em {baseDeVeiculos[i, 1]} " +
                        $"NÃO pode ser devolvido.");

                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Método que apresenta o submenu das opções dos veículos
        /// </summary>
        /// <param name="operacao"></param>
        public static void SubMenuInicial(string operacao)
        {
            Console.Clear();
            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o modelo do veículo para realizar a operação:");
        }
        #endregion
        
        /*
        /// <summary>
        /// Método que carrega o menu de Devolução - Menu opção 2.
        /// </summary>
        public static void MostrarMenuDevolucao()
        {
            SubMenuInicial("Devolução de Veículos");

            ListaBaseDeDados();

            Console.WriteLine("Digite o veículo que deseja devolver:");

            var modeloveiculo = Console.ReadLine();

            if (PesquisaVeiculoParaDevolucao(modeloveiculo))
            {
                Console.WriteLine("Você deseja devolver o veículo? Para SIM digite 1. Para NÂO digite 0.");

                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    DevolverVeiculo(modeloveiculo);
                    Console.WriteLine("\nVeículo devolvido com sucesso!");
                }
                else
                    Console.WriteLine("\nDevolução de veículo cancelada.");

                Console.WriteLine("\n\nListagem de Veículos");

                ListaBaseDeDadosCompleta();
            }
        }
        */
    }
}
