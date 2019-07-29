using BancoCeSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Informe o valor para saque: ");
            double.TryParse(Console.ReadLine(), out double valorSacar); // O valor informado é convertido.

            if(valorSacar > 0 && accountUser.Sacar(valorSacar)) //Verifica se o valor é maior que 0 e se realizou o saque.
                Console.WriteLine("Saque realizado com sucesso!");
            else
                Console.WriteLine("Operação não realizada");

            Console.WriteLine($"Saldo atual disponível: {accountUser.Saldo.ToString("N2")}"); //Mostra o saldo disponível. Abaixo segue a outra maneira.
            // Console.WriteLine($"Saldo atual disponível: {accountUser.MostrarSaldo()}");

            Console.ReadKey();
        }
    }
}
