using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int idBase = 0;
            string[,] baseDeDados = new string[2, 5];

            do
            {
                switch (ApresentaMenuInicial())
                {
                    case "1": { InserirRegistro(ref baseDeDados, ref idBase); } break;
                    case "2": { RemoverRegistro(ref baseDeDados); } break;
                    case "3": { ListaRegistros(baseDeDados); } break;
                    case "4": { ListaRegistros(baseDeDados, "true"); } break;
                    case "9": { return; }

                    default: break;
                }

            } while (true);
            
        }

        /// <summary>
        /// Método que apresenta o cabeçalho do sistema ao usuário.
        /// </summary>
        public static void CabecalhoMenu()
        {
            Console.Clear();
            Console.WriteLine(" **********************************");
            Console.WriteLine("|           Biblioteca            |");
            Console.WriteLine("|      Projeto Final Console      |");
            Console.WriteLine("| Desenvolvido por Christian Buhr |");
            Console.WriteLine(" **********************************");
        }

        /// <summary>
        /// Apresenta as opções do menu inicial.
        /// </summary>
        /// <returns>Retorna a opção do menu escolhido.</returns>
        public static string ApresentaMenuInicial()
        {
            CabecalhoMenu();
            Console.WriteLine("---------------Menu---------------");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Remover um registro");
            Console.WriteLine("3 - Listar registros");
            Console.WriteLine("4 - Listar registros apagados");
            Console.WriteLine("9 - Sair do sistema");

            Console.WriteLine("Digite o número da opção desejada");
            return Console.ReadLine();
        }

        /// <summary>
        /// Método que aumenta a base de dados para suportar novos registros.
        /// </summary>
        /// <param name="pBaseDeDados">Informar qual a base que deseja aumentar de tamanho.</param>
        public static void AumentaTamanhoDaBaseDeDados(ref string[,] pBaseDeDados)
        {
            bool aumentarBase = true;
            

            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {
                if (pBaseDeDados[i, 0] == null)
                    aumentarBase = false;
            }

            if (aumentarBase)
            {
                var copiaBaseDeDados = pBaseDeDados;

                pBaseDeDados = new string[pBaseDeDados.GetLength(0) + 3, 5];

                for (int i = 0; i < copiaBaseDeDados.GetLength(0); i++)
                {
                    pBaseDeDados[i, 0] = copiaBaseDeDados[i, 0];
                    pBaseDeDados[i, 1] = copiaBaseDeDados[i, 1];
                    pBaseDeDados[i, 2] = copiaBaseDeDados[i, 2];
                    pBaseDeDados[i, 3] = copiaBaseDeDados[i, 3];
                    pBaseDeDados[i, 4] = copiaBaseDeDados[i, 4];
                }

                Console.WriteLine("***O tamanho da base de dados foi aumentado com sucesso!***");
            }
        }

        /// <summary>
        /// Método que insere novos registros à base de dados.
        /// </summary>
        /// <param name="pBaseDeDados">Informar qual a base aonde deseja inserir um registro.</param>
        /// <param name="pIdBase">Informar a variável que controla o ID único de cada registro.</param>
        public static void InserirRegistro(ref string[,] pBaseDeDados, ref int pIdBase)
        {
            AumentaTamanhoDaBaseDeDados(ref pBaseDeDados);

            Console.WriteLine("Tela para adicionar registro");

            Console.WriteLine("Informe o nome do livro: ");
            string nomeLivro = Console.ReadLine();

            Console.WriteLine("Informe o nome do autor:");
            string autorLivro = Console.ReadLine();

            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {
                if (pBaseDeDados[i, 0] != null)
                    continue;

                pBaseDeDados[i, 0] = pIdBase++.ToString();
                pBaseDeDados[i, 1] = "true";
                pBaseDeDados[i, 2] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                pBaseDeDados[i, 3] = nomeLivro;
                pBaseDeDados[i, 4] = autorLivro;

                break;
            }

            Console.WriteLine("***Livro cadastrado com sucesso!***");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que remove os registros da visualização normal do usuário, alterando seu status.
        /// </summary>
        /// <param name="pBaseDeDados">Informar qual a base aonde deseja remover um registro.</param>
        public static void RemoverRegistro (ref string[,] pBaseDeDados)
        {
            Console.WriteLine("Tela para remover registro");

            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {
                if (pBaseDeDados[i, 1] != "false")
                    Console.WriteLine(string.Format("ID: {0} - Nome do livro: {2} - Autor: {3} - Data de alteração: {1}", pBaseDeDados[i, 0], pBaseDeDados[i, 2], pBaseDeDados[i, 3], pBaseDeDados[i, 4]));
            }
            Console.WriteLine("Por favor, informe o ID do registro que deseja remover: ");

            string id = Console.ReadLine();

            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {
                if(pBaseDeDados != null && pBaseDeDados[i,0] == id)
                {
                    pBaseDeDados[i, 1] = "false";
                    pBaseDeDados[i, 2] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    break;
                }
            }

            Console.WriteLine("***Operações finalizadas!***");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Método que apresenta os registros da base de dados.
        /// </summary>
        /// <param name="pBaseDeDados">Informar qual a base de dados que deseja listar.</param>
        /// <param name="pStatus">Parâmetro para definir se deve apresentar registros ativos ou inativos.</param>
        public static void ListaRegistros (string[,] pBaseDeDados, string pStatus = "false")
        {
            Console.WriteLine("Relatório de registros");

            if (pStatus == "true")
                Console.WriteLine("Lista de registros desativados do sistema");
            
            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
                if(pBaseDeDados[i,1] != pStatus)
                    Console.WriteLine(string.Format("ID: {0} - Nome do livro: {2} - Autor: {3} - Data de alteração: {1}", pBaseDeDados[i, 0], pBaseDeDados[i, 2], pBaseDeDados[i, 3], pBaseDeDados[i, 4]));

            Console.WriteLine("***Resultados apresentados com sucesso!***");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar em qualquer tecla.");
            Console.ReadKey();
        }
    }
}
