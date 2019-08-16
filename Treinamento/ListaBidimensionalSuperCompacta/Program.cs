using ListaBidimensionalSuperCompacta.BibliotecaListaBi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBidimensionalSuperCompacta
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaBI = new ListaBI();

            listaBI.PesquisaLista(Console.ReadKey().KeyChar.ToString());

            Console.ReadKey();
        }
    }
}
