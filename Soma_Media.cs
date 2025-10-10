using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            double media;
            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int c = 1; c <=num; c++ )
            {
                Console.Write(c + "º: ");
               
                int num2 = Convert.ToInt32(Console.ReadLine());
                soma = soma + num2;
            }
            media = soma / num;
            Console.WriteLine("Soma: " +soma);
            Console.WriteLine("Media: " + media);
           
            Console.ReadKey();
        }
    }
}
