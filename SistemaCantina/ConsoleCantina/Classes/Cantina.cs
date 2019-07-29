using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCantina.Classes
{
    class Cantina
    {
        double saldo = 20;
        double valorLanche = 5;

        public void ComprarLanche()
        {
            Console.WriteLine($"Cada lanche custa {valorLanche} reais. Quantos lanches deseja comprar?");
            int.TryParse(Console.ReadLine(), out int numLanches);

            if ((numLanches * valorLanche) <= saldo)
            {
                saldo -= (numLanches * valorLanche);
                Console.WriteLine("Lanche(s) comprado(s)");
            }
            else
                Console.WriteLine("Nâo foi possível comprar a quantidade de lanches solicitado.");
        }

        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
