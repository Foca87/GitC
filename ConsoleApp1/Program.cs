using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] nameList = new string[2] { "Valor1", "Valor2" };

            foreach (var item in nameList)
                Console.WriteLine(item);
            */

            string[] dateList = new string[10000];
            DateTime firstTime = DateTime.Now;

            for (int i = 0; i < dateList.Length; i++)
            {
                dateList[i] = DateTime.Now.ToString("yyyyMMddhhmmssfff");
                Console.WriteLine(dateList[i]);
                //dateList[i] = DateTime.Now.ToString("hh:mm:ss:ffff");
                //Thread.Sleep(1000);
            }
            
            foreach (var item in dateList)
                Console.WriteLine(item);            

            Console.WriteLine((DateTime.Now - firstTime).ToString());

            Console.ReadKey();
        }
    }
}
