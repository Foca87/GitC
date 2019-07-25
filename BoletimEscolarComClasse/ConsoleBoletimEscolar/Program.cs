using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaBoletimEscolar;

namespace ConsoleBoletimEscolar
{
    class Program
    {
        static void Main(string[] args)
        {            
            FuncoesAlunos aluno = new FuncoesAlunos();

            do
            {
                Console.Clear();
                Console.WriteLine("----------Boletim Escolar----------");
                Console.WriteLine("1 - Cadastrar novo aluno");
                Console.WriteLine("2 - Alterar notas do aluno");
                Console.WriteLine("3 - Alterar frequência do aluno");
                Console.WriteLine("4 - Relatório de alunos cadastrados");
                Console.WriteLine("9 - Excluir cadastro de novo aluno");
                Console.WriteLine("0 - Fechar o programa");
                Console.WriteLine("Informe a opção desejada");
                
                switch (Console.ReadKey().KeyChar.ToString())
                {
                    case "1": { aluno.CadastrarAluno(); } break;
                    case "2": { aluno.AlterarMediaAluno(); } break;
                    case "3": { aluno.AlterarFrequenciaAluno(); } break;
                    case "4":
                        {
                            aluno.ListarCadastrosDaBaseDeDados();

                            Console.WriteLine("Aperte qualquer tecla para retornar ao menu principal");
                            Console.ReadKey();
                        } break;
                    case "9": { aluno.ExcluirCadastroAluno(); } break;                    
                    case "0": { return; }
                    default: { Console.WriteLine("Opção incorreta! Por favor escolha novamente."); } break;
                }
            } while (true);
        }
    }
}
