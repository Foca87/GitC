using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> listaDeCarros = new List<Carros>();

            while (true)
            {
                Console.WriteLine("1 - Para adicionar um novo carro");
                Console.WriteLine("2 - Listar carros registrados");
                Console.WriteLine("9 - Para fechar o programa");

                switch (Console.ReadKey().KeyChar.ToString())
                {
                    case "1":
                        {
                            listaDeCarros.Add(new Carros()
                            {
                                Modelo = NomeDoCampo("Modelo"),
                                Ano = int.Parse(NomeDoCampo("Ano")),
                                Placa = NomeDoCampo("Placa"),
                                Potencia = int.Parse(NomeDoCampo("Potência"))
                            });
                        } break;
                    case "2":
                        {
                            foreach (Carros item in listaDeCarros)
                            {
                                Console.WriteLine($"\r\nModelo: {item.Modelo} | Ano: {item.Ano} | Placa: {item.Placa} | Potencia: {item.Potencia}");
                            }

                            Console.WriteLine("\r\nAperte qualquer tecla para retornar ao menu principal");
                            Console.ReadKey();
                        } break;
                    case "9": { return; }
                    default:
                        Console.WriteLine("Opção incorreta, por favor escolha novamente.");
                        break;
                }                
            }
        }

        public static string NomeDoCampo(string campo)
        {
            Console.WriteLine($"\r\nPor favor, informe o (a) {campo} do carro: ");
            return Console.ReadLine();
        }
    }
}
