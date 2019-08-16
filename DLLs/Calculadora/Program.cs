using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeCalculadora.BibliotecaDeOperacoesAritmeticas;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesAritmeticas bbCalc = new OperacoesAritmeticas();

            Console.WriteLine(bbCalc.Adicao(5,10));
            Console.WriteLine(bbCalc.Subtracao(5,10));
            Console.WriteLine(bbCalc.Multiplicacao(5,10));
            Console.WriteLine(bbCalc.Divisao(5,10));

            Console.ReadKey();
        }
    }
}
