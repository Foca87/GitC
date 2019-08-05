using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeCalculadora.BibliotecaDeOperacoesAritmeticas
{
    public class OperacoesAritmeticas
    {
        public int Adicao(int pX, int pY)
        {
            return pX + pY;
        }

        public int Subtracao(int pX, int pY)
        {
            return pX - pY;
        }

        public float Multiplicacao(float pX, float pY)
        {
            return pX * pY;
        }

        public float Divisao(float pX, float pY)
        {
            return pX / pY;
        }
    }
}
