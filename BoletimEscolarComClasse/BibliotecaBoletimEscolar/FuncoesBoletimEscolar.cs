using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBoletimEscolar
{
    public class FuncoesBoletimEscolar
    {
        float media;
        int frequencia;

        /// <summary>
        /// Calcula a média de 3 valores.
        /// </summary>
        /// <param name="nota1">Primeira nota para fazer o cálculo da média.</param>
        /// <param name="nota2">Segunda nota para fazer o cálculo da média.</param>
        /// <param name="nota3">Terceira nota para fazer o cálculo da média.</param>
        /// <returns></returns>
        public float CalcularMedia(float nota1, float nota2, float nota3)
        {
            return media = (nota1 + nota2 + nota3) / 3;
        }

        /// <summary>
        /// Calcula a frequência do aluno em %.
        /// </summary>
        /// <param name="totalAulas">Informar total de aulas.</param>
        /// <param name="totalFaltas">Informar o total de faltas do aluno.</param>
        /// <returns></returns>
        public int CalcularFrequencia(int totalAulas, int totalFaltas)
        {
            return frequencia = ((totalAulas - totalFaltas) * 100) / totalAulas;            
        }

        /// <summary>
        /// Apresenta a situação do aluno informando se está aprovado ou não.
        /// </summary>
        public void ApresentarSituacao()
        {
            if (media >= 7 && frequencia >= 75)
                Console.WriteLine("\r\nAluno aprovado");
            else
                Console.WriteLine("\r\nAluno reprovado");
        }

        /// <summary>
        /// Insere a situação do aluno informando se está aprovado ou não com True ou False
        /// </summary>
        public string InserirSituacao()
        {
            if (media >= 7 && frequencia >= 75)
                return "Aprovado";
            else
                return "Reprovado";
        }
    }
}
