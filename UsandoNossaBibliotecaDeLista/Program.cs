using CriacaoDeListaOrganizada.BibliotecaLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoNossaBibliotecaDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var listView = new FuncoesLista();

            listView.MostrarLista();
            listView.ApagarLista();
            listView.MostrarLista();
            listView.MudarTamanho(30);
            listView.PopularLista();
            listView.MostrarLista();
        }
    }
}
