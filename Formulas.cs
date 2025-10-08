using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, del, f, m, a2, v, vo, a3, t;
            Console.WriteLine("1-Bhaskara");

            Console.WriteLine("2-Força");

            Console.WriteLine("3-Velocidade");
            int menu = Convert.ToInt32(Console.ReadLine());




            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Digite o valor de a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor de b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor de c: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    del = Math.Pow(b, 2) - 4 * a * c;
                    x1 = (-b) + Math.Sqrt(del) / (2 * a);
                    x2 = (-b) - Math.Sqrt(del) / (2 * a);

                    Console.WriteLine("Valor de Delta " + del);
                    Console.WriteLine("Valor de x1: " + x1);
                    Console.WriteLine("Valor de x2: " + x2);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Digite o valor da massa: ");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o valor da aceleração: ");
                    a2 = Convert.ToDouble(Console.ReadLine());

                    f = m * a2;
                    Console.WriteLine("Valor da força é : " + f);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Digite a velocidade inicial: ");
                    vo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor da aceleração: ");
                    a3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor do tempo: ");
                    t = Convert.ToDouble(Console.ReadLine());

                    v = vo + a3 * t;

                    Console.WriteLine("A velocidade é: " + v);
                    break;
            }

        }
    }
}
