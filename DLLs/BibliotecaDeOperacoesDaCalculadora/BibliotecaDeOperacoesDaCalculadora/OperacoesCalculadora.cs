using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeOperacoesDaCalculadora
{
    public class OperacoesCalculadora
    {
        public class OperacoesAritmeticas
        {

            /// <summary>
            /// Faz a soma de dois valores (x e y).
            /// </summary>
            /// <param name="pX">Primeiro valor. Aceita float.</param>
            /// <param name="pY">Segundo valor. Aceita float.</param>
            /// <returns>Retorna a soma de ambos os valores informados em float.</returns>
            public float Adicao(float pX, float pY)
            {
                return pX + pY;
            }

            /// <summary>
            /// Faz a subtração de doís valores, seguindo a ordem informada (x e y).
            /// </summary>
            /// <param name="pX">Valor float de onde será subtraído.</param>
            /// <param name="pY">Valor float que irá subtrair.</param>
            /// <returns>Retorna o resultado da subtração em float.</returns>
            public float Subtracao(float pX, float pY)
            {
                return pX - pY;
            }

            /// <summary>
            /// Multiplica dois valores (x e y).
            /// </summary>
            /// <param name="pX">Primeiro valor. Aceita até float.</param>
            /// <param name="pY">Segundo valor. Aceita até float.</param>
            /// <returns>Retorna o resultado da multiplicação em float.</returns>
            public float Multiplicacao(float pX, float pY)
            {
                return pX * pY;
            }

            /// <summary>
            /// Faz a divisão de doís valores, seguindo a ordem informada (x e y).
            /// </summary>
            /// <param name="pX">Valor float que será o dividendo.</param>
            /// <param name="pY">Valor float que será o divisor.</param>
            /// <returns>Retorna o resultado da divisão em float.</returns>
            public float Divisao(float pX, float pY)
            {
                return pX / pY;
            }

            /// <summary>
            /// Calcula a área de um retângulo.
            /// </summary>
            /// <param name="pX">Informe o valor da base do retângulo (float).</param>
            /// <param name="pY">Informe o valor da altura do retângulo (float).</param>
            /// <returns>Retorna o resultado da multiplicação em float.</returns>
            public float AreaRetangulo(float pX, float pY)
            {
                return pX * pY;
            }

            /// <summary>
            /// Calcula a área de um triângulo equilátero.
            /// </summary>
            /// <param name="pBase">Informe o valor da base do triângulo (float).</param>
            /// <param name="pAltura">Informe o valor da altura do triângulo (float).</param>
            /// <returns>Retorna um float com o valor da área do triângulo.</returns>
            public float AreaTriangulo (float pBase, float pAltura)
            {
                return (pBase * pAltura) / 2;
            }

            /// <summary>
            /// Calcula o raio de um Círculo utilizando da área do mesmo.
            /// </summary>
            /// <param name="pArea">Informe a área do círculo (float).</param>
            /// <returns>Retorna um double com o valor do raio do círculo.</returns>
            public double RaioDoCirculo(float pArea)
            {
                return Math.Sqrt(pArea / Math.PI);
            }
        }
    }
}
