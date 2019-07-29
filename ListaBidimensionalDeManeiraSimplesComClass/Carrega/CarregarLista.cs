using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBidimensionalDeManeiraSimplesComClass.Carrega
{
    class CarregarLista
    {
        string[,] listaDeNome;

        /// <summary>
        /// Retorna a lista de nomes apenas como leitura
        /// </summary>
        public string[,] ListaNome { get { return listaDeNome; } }
        
        /// <summary>
        /// Método Construtor que sempre recebe o nome da classe.
        /// </summary>
        /// <param name="arrayBi">Aray que já deve estar assinado.</param>
        public CarregarLista()
        {
            listaDeNome = new string[5, 2]; // Assinado a lista dentro do método Construtor, com isso a mesma já está pronta para uso dos demais métodos sem precisar de um parâmetro para isso.
        }

        /// <summary>
        /// Método que carrega as informações dentro da lista criado no método "Main" e as apresenta na tela.
        /// </summary>
        /// <param name="arrayBi"></param>
        public void CarregaInformacoesEListaElasEmTela()
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++) // Para arrays bidimensionais deve-se utilizar o GetLength informando entre () qual a coluna que deve ter sua quantidade de linhas contadas.
            {
                listaDeNome[i, 0] = i.ToString(); // Carregando (assinando, ou atribuindo) o que podemos chamar de "ID" para identificar nosso registro único.
                listaDeNome[i, 1] = $"Felipe_{i + 10}"; // Adicionando uma informação extra para preencher o campo na segunda coluna.
            }

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {listaDeNome[i, 0]} - Nome: {listaDeNome[i, 1]}"); // Formatado como string para apresentar os dados.
            }
        }
    }
}
