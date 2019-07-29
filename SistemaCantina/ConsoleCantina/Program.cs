using ConsoleCantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCantina
{
    class Program
    {
        static void Main(string[] args)
        {
            Cantina cantina = new Cantina();

            while (true)
            {
                cantina.ComprarLanche();

                Console.WriteLine($"Você ainda tem R$ {cantina.MostrarSaldo()}.");

                Console.WriteLine("Caso não queira comprar outro lanche aperte 9");
                if (Console.ReadKey().KeyChar.ToString() == "9")
                    break;
            }
        }
    }
}
