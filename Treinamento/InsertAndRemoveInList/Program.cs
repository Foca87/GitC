using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemoveInList
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] baseDeDados = new string[2, 5];
            int IndiceBaseDeDados = 0;

            Console.WriteLine("Iniciando sistema de lista de Nome e idade.");

            var escolhaInicial = ApresentaMenuInicial();

            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InserirValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformações(ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break;
                    case "5": { return; }
                }

                escolhaInicial = ApresentaMenuInicial();
            }
        }

        /// <summary>
        /// Apresenta as informações do menu inicial.
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Remover um registro");
            Console.WriteLine("3 - Listar registros");
            Console.WriteLine("4 - Listar registros apagados");
            Console.WriteLine("5 - Sair do sistema");

            Console.WriteLine("Digite o número da opção desejada: ");
            return Console.ReadLine(); // Retorna diretamente o menu escolhido.
        }

        /// <summary>
        /// Método que insere informações dentro da base de dados.
        /// </summary>
        /// <param name="baseDeDados"> Base de dados como ref para alterar para todos os métodos.</param>
        /// <param name="indiceBase">Índice da base como ref para alterar para todos os métodos.</param>
        public static void InserirValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("--------Inserindo valores na lista--------");

            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            var idade = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (indiceBase++).ToString();
                baseDeDados[i, 1] = nome;
                baseDeDados[i, 2] = idade;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }

            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Mostra as informações dentro da lista de dados "baseDeDados".
        /// </summary>
        /// <param name="baseDeDados">Informar qual lista deve ser apresentada.</param>
        /// <param name="mostrarResgistrosNAtivos">Quando identificado com o valor true, o mesmo mostra os registros que não estão ativos dentro do sistema.</param>
        public static void MostrarInformacoes (string[,] baseDeDados, string mostrarResgistrosNAtivos = "false")
        {
            Console.WriteLine("Apresentação das informações dentro da base de dados.");

            if (mostrarResgistrosNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                if(baseDeDados[i,3] != mostrarResgistrosNAtivos)
                    Console.WriteLine($"ID: {baseDeDados[i,0]} " +
                        $"- Nome: {baseDeDados[i, 1]} " +
                         $"- Idade: {baseDeDados[i, 2]} " +
                          $"- Data de Alteração: {baseDeDados[i,4]}");

            Console.WriteLine("Resultados apresentados com sucesso");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar em qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método utilizado para remover um registro pelo id do resgistro.
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele irá remover o resgistro pelo id.</param>
        public static void RemoverInformações(ref string[,] baseDeDados)
        {
            Console.WriteLine("Área de remoção de registro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                if(baseDeDados[i,3] != "false")
                    Console.WriteLine($"ID: {baseDeDados[i, 0]} " +
                        $"- Nome: {baseDeDados[i, 1]} " +
                        $"- Idade: {baseDeDados[i, 2]}");
             
            Console.WriteLine("Informe o ID do registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 3] = "false";
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }

            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método para aumentar o tamanho da lista.
        /// </summary>
        /// <param name="baseDeDados">Informar qual a lista que deve ser aumentada.</param>
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            var limiteDaLista = true; 

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            if (limiteDaLista) 
            {
                var listaCopia = baseDeDados; 

                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    baseDeDados[i, 2] = listaCopia[i, 2];
                    baseDeDados[i, 3] = listaCopia[i, 3];
                    baseDeDados[i, 4] = listaCopia[i, 4];
                }

                Console.WriteLine("O tamanho da lista foi atualizado!");
            }

        }
    }
}
