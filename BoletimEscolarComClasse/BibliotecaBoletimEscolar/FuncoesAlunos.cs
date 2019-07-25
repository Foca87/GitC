using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBoletimEscolar
{
    public class FuncoesAlunos
    {
        string[,] cadastroAlunos = new string[5, 5];
        int matricula = 1;
        FuncoesBoletimEscolar boletimAluno = new FuncoesBoletimEscolar();

        /// <summary>
        /// Apresenta a mensagem padrão ao fim da operação e aguarda interação do usuário para continuar a execução.
        /// </summary>
        private static void MensagemPadrao()
        {
            Console.WriteLine("\r\nOperação finalizada com sucesso!");

            Console.WriteLine("Aperte qualquer tecla para retornar ao menu principal");
            Console.ReadKey();
        }

        /// <summary>
        /// Cadastra novas informações na base de dados.
        /// </summary>
        public void CadastrarAluno()
        {
            for (int i = 0; i < cadastroAlunos.GetLength(0); i++)
            {
                if (cadastroAlunos[i, 0] != null)
                    continue;

                cadastroAlunos[i, 0] = matricula++.ToString();

                Console.WriteLine("\r\nInforme o nome do aluno: ");
                cadastroAlunos[i, 1] = ValidarNome();

                DefinirNota(i);
                
                DefinirFrequencia(i);

                cadastroAlunos[i, 4] = boletimAluno.InserirSituacao();

                break;
            }

            MensagemPadrao();
        }

        /// <summary>
        /// Lista todos os alunos e demais informações cadastradas na base de dados.
        /// </summary>
        public void ListarCadastrosDaBaseDeDados()
        {
            Console.WriteLine("\r\n--------------------Cadastro de Alunos--------------------");

            for (int i = 0; i < cadastroAlunos.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Matrícula: {0} Nome: {1}| Média: {2}| Frequência: {3}% | Situação: {4}",
                    cadastroAlunos[i, 0], cadastroAlunos[i, 1], cadastroAlunos[i, 2], cadastroAlunos[i, 3], cadastroAlunos[i, 4]));
            }
        }

        /// <summary>
        /// Apresenta os registros e solicita qual registro deve ser apagado da base de dados.
        /// </summary>
        public void ExcluirCadastroAluno()
        {
            ListarCadastrosDaBaseDeDados();

            Console.WriteLine("Informe a matrícula do aluno a ser apagado:");
            string matricula = Console.ReadKey().KeyChar.ToString();

            for (int i = 0; i < cadastroAlunos.GetLength(0); i++)
            {
                if (cadastroAlunos[i, 0] == matricula)
                {
                    for (int j = 0; j < cadastroAlunos.GetLength(1); j++)
                        cadastroAlunos[i, j] = string.Empty;

                    break;
                }
            }

            MensagemPadrao();
        }

        /// <summary>
        /// Altera a média solicitando as notas do aluno novamente.
        /// </summary>
        public void AlterarMediaAluno()
        {
            ListarCadastrosDaBaseDeDados();

            Console.WriteLine("Informe a matrícula do aluno que deseja alterar a média:");
            string matricula = Console.ReadKey().KeyChar.ToString();

            for (int i = 0; i < cadastroAlunos.GetLength(0); i++)
            {
                if (cadastroAlunos[i, 0] == matricula)
                {
                    DefinirNota(i);

                    break;
                }
            }

            MensagemPadrao();
        }

        private void DefinirNota(int indice)
        {
            Console.WriteLine("\r\nInforme a primeira nota do aluno: ");
            float nota1 = ValidarNota();
            Console.WriteLine("Informe a segunda nota do aluno: ");
            float nota2 = ValidarNota();
            Console.WriteLine("Informe a terceira nota do aluno: ");
            float nota3 = ValidarNota();
            cadastroAlunos[indice, 2] = boletimAluno.CalcularMedia(nota1, nota2, nota3).ToString();
        }

        /// <summary>
        /// Faz a validação da nota que o usuário está digitanto.
        /// </summary>
        /// <returns>Retorna a nota caso seja um valor dentro da variação permitida.</returns>
        private float ValidarNota()
        {
            bool valida = false;
            do
            {
                float.TryParse(Console.ReadLine(), out float nota);

                if (nota >= 0 && nota <= 10)
                    return nota;
                else
                    Console.WriteLine("A nota deve ser um valor entre 0 e 10.");

            } while (!valida);

            return 0;
        }

        /// <summary>
        /// Altera a frequência solicitando as faltas do aluno novamente.
        /// </summary>
        public void AlterarFrequenciaAluno()
        {
            ListarCadastrosDaBaseDeDados();

            Console.WriteLine("Informe a matrícula do aluno que deseja alterar a média:");
            string matricula = Console.ReadKey().KeyChar.ToString();

            for (int i = 0; i < cadastroAlunos.GetLength(0); i++)
            {
                if (cadastroAlunos[i, 0] == matricula)
                {
                    DefinirFrequencia(i);

                    break;
                }
            }

            MensagemPadrao();
        }

        private void DefinirFrequencia(int indice)
        {
            Console.WriteLine("\r\nInforme o total de aulas deste período: ");
            int totalAulas = ValidarAulas();
            Console.WriteLine("Informe o total de faltas do aluno deste período: ");
            int totalFaltas = ValidarFaltas(totalAulas);
            cadastroAlunos[indice, 3] = boletimAluno.CalcularFrequencia(totalAulas, totalFaltas).ToString();
        }

        /// <summary>
        /// Faz a validação da quantidade de aulas que o usuário informando.
        /// </summary>
        /// <returns>Retorna a quantidade de aulas caso seja um valor dentro da variação permitida.</returns>
        private int ValidarAulas()
        {
            bool valida = false;

            do
            {
                int.TryParse(Console.ReadLine(), out int totalAulas);

                if (totalAulas >= 1 && totalAulas <= 360)
                    return totalAulas;
                else
                    Console.WriteLine("O total de aulas deve ser um valor entre 1 e 360.");
            } while (!valida);

            return 1;
        }

        /// <summary>
        /// Faz a validação da quantidade de faltas que o usuário informa.
        /// </summary>
        /// <returns>Retorna a quantidade de faltas caso seja valor dentro da variação permitida.</returns>
        private int ValidarFaltas(int totalAulas)
        {
            bool valida = false;

            do
            {
                int.TryParse(Console.ReadLine(), out int totalFaltas);

                if (totalFaltas >= 1 && totalFaltas <= totalAulas)
                    return totalFaltas;
                else
                    Console.WriteLine("O total de faltas deve ser um valor entre 1 e 360, sem ultrapassar o valor do total de aulas.");
            } while (!valida);

            return 1;
        }

        /// <summary>
        /// Faz a validação do tamanho do nome informado.
        /// </summary>
        /// <returns>Retorna o nome informado.</returns>
        private string ValidarNome()
        {
            bool valido = false;

            do
            {
                string nome = Console.ReadLine();
                int tamanhoNome = nome.Length;

                if (tamanhoNome > 0 && tamanhoNome <= 100)
                    return nome;
                else
                    Console.WriteLine("O nome digitado não é válido. Por favor tente novamente.");
            } while (!valido);

            return "Nome inválido";
        }
    }
}
