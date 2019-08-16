using ListaBidimensionalDeManeiraSimplesComClass.Carrega;
using ListaBidimensionalDeManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBidimensionalDeManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var carregaLista = new CarregarLista();

            carregaLista.CarregaInformacoesEListaElasEmTela(); // Chama o método para carregar a lista.

            var mostrarLista = new MostrarLista(); // Carregamos novamente, mas agora a classe MostrarLista.

            mostrarLista.PesquisandoInformacoesNaLista(carregaLista.ListaNome, "0"); // Ó método é chamado novamente.

            Console.ReadKey();
        }
    }
}
