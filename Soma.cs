using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int soma = 0;
            
            Console.WriteLine("Digite 10 números:");

            for (int c = 1; c <= 10; c++)
            {
                Console.Write( c + "º: ");
                int num = Convert.ToInt32(Console.ReadLine());
               if (num > 10)
                {
                    soma = soma + num;
                }
                else
                {

                }


            }
            Console.WriteLine("Soma: " + soma);
            Console.ReadKey();
        }
    }
}
