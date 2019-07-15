using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1507
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listanomesobrenome = new string[2, 3];
            int id = 0;

            InserirRegistro(ref listanomesobrenome, ref id);
            ListarRegistros(listanomesobrenome);
            Console.ReadKey();

            InserirRegistro(ref listanomesobrenome, ref id);
            ListarRegistros(listanomesobrenome);
            Console.ReadKey();
        }

        /// <summary>
        /// Método que salva as informações digitadas pelo usuário na lista.
        /// </summary>
        /// <param name="lista">Identificar qual a lista que deve receber os dados.</param>
        /// <param name="idLista">Informar a variável com o identificador único.</param>
        public static void InserirRegistro(ref string[,] lista, ref int idLista)
        {
            for (int i = 0; i < lista.GetLength(0); i++)
            {
                if (lista[i,0] != null)
                    continue;

                lista[i, 0] = (idLista++).ToString();

                Console.WriteLine("\rInforme um nome para adicionar ao cadastro:");
                lista[i, 1] = Console.ReadLine();

                Console.WriteLine("\rInforme o sobrenome para adicionar ao cadastro: ");
                lista[i, 2] = Console.ReadLine();

                Console.WriteLine("Deseja inserir um nove registro? 1 - SIM | 0 - NÃO");
                
                if (Console.ReadKey().KeyChar.ToString() == "0")
                    break;

                AumentaTamanhoLista(ref lista);
            }
        }

        /// <summary>
        /// Método que lista os registros armazenados.
        /// </summary>
        /// <param name="lista">Informar qual a lista que deve ser apresentada.</param>
        public static void ListarRegistros(string[,] lista)
        {
            for (int i = 0; i < lista.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Matrícula: {0} | Nome Completo: {1} {2}", lista[i,0], lista[i,1], lista[i,2]));
            }
        }

        /// <summary>
        /// Método que aumenta o tamanho da lista atual.
        /// </summary>
        /// <param name="lista">Informar qual a lista que deve ser aumentada.</param>
        public static void AumentaTamanhoLista(ref string[,] lista)
        {
            bool aumentarLista = true;

            for (int i = 0; i < lista.GetLength(0); i++)
            {
                if (lista[i, 0] == null)
                    aumentarLista = false;
            }

            if (aumentarLista)
            {
                string[,] backupLista = lista;
                lista = new string[lista.GetLength(0) + 2, 3];

                for (int i = 0; i < backupLista.GetLength(0); i++)
                {
                    lista[i, 0] = backupLista[i, 0];
                    lista[i, 1] = backupLista[i, 1];
                    lista[i, 2] = backupLista[i, 2];
                }

                Console.WriteLine("O tamanho da lista foi atualizado!");
            }
        }


        public static void SobrescreveRegistro(ref string[,] lista, int idLista)
        {

        }
    }
}
