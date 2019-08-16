using CriacaoDeListaOrganizada.BibliotecaLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaOrganizada
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new FuncoesLista();

            lista.MostrarLista();
            lista.ApagarLista();
            lista.MostrarLista();
            lista.MudarTamanho(50);
            lista.PopularLista();
            lista.MostrarLista();
        }
    }
}
