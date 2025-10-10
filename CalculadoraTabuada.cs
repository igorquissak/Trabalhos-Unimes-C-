using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,num2, c;

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite até que número quer ver o seu ser multiplicado: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int soma = 0;
            
            for (c = 1; c <= num2; c++)
            {

                
                soma = soma + num;

                Console.WriteLine(num + "x" + c + "=" + soma);
                
                Thread.Sleep(500);
            }
            
            Console.ReadKey();
            
        }
    }
}
