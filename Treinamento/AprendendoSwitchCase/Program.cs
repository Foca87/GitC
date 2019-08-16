using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AprendendoSwitchCase
{
    static class Tetris
    {

        static void Main()
        {
            var dateVerify = DateTime.Now.ToString("HH:mm"); // A variável dateVerify recebe a Hora e o minuto.

            Console.WriteLine("informe sua fileira"); // Pergunta qual fileira que irá executar.
            var fileira = Console.ReadLine(); // Pega o número informado.

            Console.WriteLine("Informe a hora de inicio no formato HH:mm");
            var timeStart = Console.ReadLine(); // É assinado a variável de comparação.

            while (dateVerify != timeStart) // Laço de repetição que fica rodando enquanto aguarda a hora marcada.
            {                
                dateVerify = DateTime.Now.ToString("HH:mm"); // Atualiza o valor da variável "dateVerify" com a hora e minutos atuais.
            }

            var startTimerIcrement = 200; // Seta o tempo de incremento entre as execuções.

            switch (fileira) // Pega um valor e cria uma lista para o mesmo e executa de acordo com a chamada.
            {
                // O case identifica que ele precisa fazer uma escolha e pede o número escolhido.
                case "1":
                    {
                        Fileira1(startTimerIcrement); // Executa a chamada de acordo com o numero escolhido.
                    } break; // O break finaliza a operação.
                case "2": { Fileira2(startTimerIcrement); } break;
                case "3": { Fileira3(startTimerIcrement); } break;
                case "4": { Fileira4(startTimerIcrement); } break;
                case "5": { Fileira5(startTimerIcrement); } break;
                case "6": { Fileira6(startTimerIcrement); } break;
                case "7": { Fileira7(startTimerIcrement); } break;
                case "8": { Fileira8(startTimerIcrement); } break;
                case "9": { Fileira9(startTimerIcrement); } break;
                case "10": { Fileira10(startTimerIcrement); } break;
                default: { Console.WriteLine("Não foi uma escolha válida dentro do menu de opções."); } break; // Em caso de não ser informado uma opção válida, ele executa a opção "padrão".
            }

            Console.ReadKey();

        }

        static void Fileira1(int thread)
        {
            Thread.Sleep(thread);
            Console.Beep(1320, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1056, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(880, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1056, 250);
        }
        static void Fileira2(int thread)
        {
            Thread.Sleep(thread * 2);
            Console.Beep(990, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1320, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1188, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(990, 250);
        }
        static void Fileira3(int thread)
        {
            Thread.Sleep(thread * 3);
            Console.Beep(1056, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1188, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1408, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(990, 250);
        }
        static void Fileira4(int thread)
        {
            Thread.Sleep(thread * 4);
            Console.Beep(1188, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1056, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1760, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1056, 250);
        }
        static void Fileira5(int thread)
        {
            Thread.Sleep(thread * 5);
            Console.Beep(1320, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(990, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1584, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1188, 250);
        }
        static void Fileira6(int thread)
        {
            Thread.Sleep(thread * 6);
            Console.Beep(1188, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1056, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1408, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1320, 250);//
        }
        static void Fileira7(int thread)
        {
            Thread.Sleep(thread * 7);
            Console.Beep(1056, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1188, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1320, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1056, 250);
        }
        static void Fileira8(int thread)
        {
            Thread.Sleep(thread * 8);
            Console.Beep(990, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1320, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1056, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(880, 250);
        }
        static void Fileira9(int thread)
        {
            Thread.Sleep(thread * 9);
            Console.Beep(880, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1056, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1320, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(880, 250);
        }
        static void Fileira10(int thread)
        {
            Thread.Sleep(thread * 10);
            Console.Beep(880, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(880, 250);
            Thread.Sleep(thread * 10);
            Console.Beep(1188, 250);
        }

    }

}
