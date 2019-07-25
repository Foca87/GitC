using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClassesEstacionamento
{
    class AlterarRegistroDeCarros
    {
        string[,] baseDeDados = new string[5,4];


        public void RegistrarCarro()
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                Console.WriteLine("----------Controle do Estacionamento----------");

                Console.WriteLine("Informe a placa do veículo: ");
                baseDeDados[i, 0] = Console.ReadLine();

                Console.WriteLine("Informe o modelo do veículo: ");
                baseDeDados[i, 1] = Console.ReadLine();

                baseDeDados[i, 2] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                baseDeDados[i, 3] = null;
            }
        }

        public void ListarRegistros()
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Modelo: {1} | Placa: {0} | Entrada: {2} | Saída: {3}", 
                    baseDeDados[i, 0], baseDeDados[i, 1], baseDeDados[i, 2], baseDeDados[i, 3]));
            }
        }

        public void ListarCarrosNoEstacionamento()
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 4] != null)
                    continue;

                Console.WriteLine(string.Format("Modelo: {1} | Placa: {0} | Entrada: {2} | Saída: {3}",
                    baseDeDados[i, 0], baseDeDados[i, 1], baseDeDados[i, 2], baseDeDados[i, 3]));
            }
        }

        public void PesquisaRegistro()
        {

        }
    }
}
