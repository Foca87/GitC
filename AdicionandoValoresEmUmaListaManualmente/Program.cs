using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoValoresEmUmaListaManualmente
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[10, 2]; // Cria a lista.
            int idParaLista = 0; // Cria uma variável externa para servir de identificador único.

            InsereRegistro(ref listaDeNome, ref idParaLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeNome, ref idParaLista);

            Console.ReadKey();
        }

        /// <summary>
        /// Método que grava novos registros na lista.
        /// </summary>
        /// <param name="listaDeNome">Lista com os nomes.</param>
        /// <param name="idParaLista">Identificador único.</param>
        public static void InsereRegistro(ref string[,] listaDeNome, ref int idParaLista)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++) // Laço para informar os registros ao array.
            {
                if (listaDeNome[i, 0] != null)
                    continue;

                Console.WriteLine("\rInforme um nome para adicionar ao registro: ");
                var nome = Console.ReadLine();

                listaDeNome[i, 0] = (idParaLista++).ToString();  // O identificador único externo é incrementado, mesmo saindo do laço.
                listaDeNome[i, 1] = nome; // Adiciona o nome na lista.

                Console.WriteLine("Deseja inserir um novo registro? 1 - SIM | 0 - NÃO"); // Verifica se deseja inserir mais nomes na lista.
                var continuar = Console.ReadKey().KeyChar.ToString(); // ReadKey lê uma única tecla, mas não retorna o seu valor, 
                                                                      // por isso é utilizado o KeyChar que pega o valor que é convertido 
                                                                      // para string para fazer a comparação.

                if (continuar == "0")
                    break; // Comando reservado do C# que para o laço de repetição ou o sequênciador lógico.

                AumentaTamanhoLista(ref listaDeNome);
            }

            Console.WriteLine("\r\nRegistro adicionados com sucesso, segue lista de informações adicionais:");

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Registro ID {0} - Nome: {1}", listaDeNome[i, 0], listaDeNome[i, 1])); // string.Format funciona da mesma forma que o "$".
                                                                                                                       // A diferença é que o string.Format é melhor para
                                                                                                                       // grandes quantidades de dados.
            }
        }

        /// <summary>
        /// Método para aumentar o tamanho da lista.
        /// </summary>
        /// <param name="ListaDeNome"></param>
        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {
            var limiteDaLista = true; // Verifica se precisa criar uma lista maior.

            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                if (ListaDeNome[i, 0] == null) // Caso ainda existir registros disponíveis ele seta a variável limiteDaLista para false.
                    limiteDaLista = false;
            }

            if (limiteDaLista) // Caso não tenha mais espaços a variável está como true o que indica que precisamos aumentar nossa lista.
            {
                var listaCopia = ListaDeNome; // Copia e armazena nossa lista temporariamente para não perder os valores armazenados.

                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2]; // Aqui a lista é limpa e criada novamente com mais espaços.

                for (int i = 0; i < listaCopia.GetLength(0); i++) // Copia os arquivos da lista temporária (anterior) para a nova lista que é maior.
                {
                    ListaDeNome[i, 0] = listaCopia[i, 0]; // Copia as informações da primeira coluna.
                    ListaDeNome[i, 1] = listaCopia[i, 1]; // Copia as informações da segunda coluna.
                }

                Console.WriteLine("O tamanho da lista foi atualizado!");
            }
            
        }
    }
}
