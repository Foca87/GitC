using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraClass;

namespace ProjetoCalculadoraComClasseImportada
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calculadora = new Calcular();

            do
            {
                Console.Clear();
                Console.WriteLine("----------Calculadora----------");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Calcular Área de Retângulo");
                Console.WriteLine("6 - Calcular Área de Triângulo");
                Console.WriteLine("7 - Calcular o Raio do Círculo");
                Console.WriteLine("0 - Fechar o programa");
                Console.WriteLine("Informe a opção desejada");

                switch (Console.ReadKey().KeyChar.ToString())
                {
                    case "1":
                        {
                            Console.WriteLine("\r\nDigite o primeiro valor: ");
                            double.TryParse(Console.ReadLine(), out double valorX);
                            Console.WriteLine("Digite o segundo valor: ");
                            double.TryParse(Console.ReadLine(), out double valorY);

                            Console.WriteLine(string.Format("{0} + {1} = {2}", valorX, valorY, calculadora.Somar(valorX, valorY)));

                            Console.ReadKey();

                        } break;
                    case "2":
                        {
                            Console.WriteLine("\r\nDigite o primeiro valor: ");
                            double.TryParse(Console.ReadLine(), out double valorX);
                            Console.WriteLine("Digite o segundo valor: ");
                            double.TryParse(Console.ReadLine(), out double valorY);

                            Console.WriteLine(string.Format("{0} - {1} = {2}", valorX, valorY, calculadora.Subtrair(valorX, valorY)));

                            Console.ReadKey();

                        } break;
                    case "3":
                        {
                            Console.WriteLine("\r\nDigite o primeiro valor: ");
                            double.TryParse(Console.ReadLine(), out double valorX);
                            Console.WriteLine("Digite o segundo valor: ");
                            double.TryParse(Console.ReadLine(), out double valorY);

                            Console.WriteLine(string.Format("{0} * {1} = {2}", valorX, valorY, calculadora.Multiplicar(valorX, valorY)));

                            Console.ReadKey();

                        } break;
                    case "4":
                        {
                            Console.WriteLine("\r\nDigite o primeiro valor: ");
                            double.TryParse(Console.ReadLine(), out double valorX);
                            Console.WriteLine("Digite o segundo valor: ");
                            double.TryParse(Console.ReadLine(), out double valorY);

                            Console.WriteLine(string.Format("{0} + {1} = {2}", valorX, valorY, calculadora.Dividir(valorX, valorY)));

                            Console.ReadKey();

                        } break;
                    case "5":
                        {
                            Console.WriteLine("\r\nDigite o valor da base do retângulo: ");
                            double.TryParse(Console.ReadLine(), out double valorX);
                            Console.WriteLine("Digite o valor da altura do retângulo: ");
                            double.TryParse(Console.ReadLine(), out double valorY);

                            Console.WriteLine($"A área do retângulo é igual a {calculadora.CalcularAreaRetangulo(valorX,valorY)}");

                            Console.ReadKey();

                        } break;
                    case "6":
                        {
                            Console.WriteLine("\r\nDigite o valor da base do triângulo: ");
                            double.TryParse(Console.ReadLine(), out double valorX);
                            Console.WriteLine("Digite o valor da altura do triângulo: ");
                            double.TryParse(Console.ReadLine(), out double valorY);

                            Console.WriteLine($"A área do triângulo é igual a {calculadora.CalcularAreaTriangulo(valorX, valorY)}");

                            Console.ReadKey();

                        } break;
                    case "7":
                        {
                            Console.WriteLine("\r\nDigite o valor da área do círculo: ");
                            double.TryParse(Console.ReadLine(), out double valorX);

                            Console.WriteLine($"O valor do raio do círculo é igual a {calculadora.CalcularRaioCirculo(valorX)}");

                            Console.ReadKey();

                        } break;

                    case "0": { return; }
                    default: { Console.WriteLine("\r\nOpção incorreta! Por favor escolha novamente."); } break;
                }

            } while (true);
        }
    }
}
