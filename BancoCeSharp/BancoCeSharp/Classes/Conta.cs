using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    class Conta
    {
        double saldo = 0;

        public double Saldo { get { return saldo; } } // Propriedade que contem o valor do saldo.
        public Conta()
        {
            saldo = 1000; //Bonus de mil reais para iniciar operação daytrade.
        }

        /// <summary>
        /// Método para sacar o dinheiro de acordo com o saldo disponível.
        /// </summary>
        /// <param name="valor">Valor para sacar.</param>
        /// <returns>Retorna se o saque foi feito ou não.</returns>
        public bool Sacar (double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor; // desconta do valor em saldo na conta.
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método para mostrar o saldo em conta disponível.
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}