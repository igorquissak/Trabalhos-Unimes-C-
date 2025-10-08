using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;
            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("5-Potênciação");
            Console.WriteLine("6-Radiciação");
            Console.WriteLine("7-Mod");

            int menu = Convert.ToInt32(Console.ReadLine());




            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Primeiro valor: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(valor1 + valor2);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Primeiro valor: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(valor1 - valor2);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Primeiro valor: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(valor1 * valor2);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Primeiro valor: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(valor1 / valor2);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Primeiro valor: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(Math.Pow(valor1, valor2);
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Primeiro valor: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(Math.Sqrt(valor1));
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Primeiro valor: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(valor1 % valor2);
                    break;




            }

        }
    }
}
