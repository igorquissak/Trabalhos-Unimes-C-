using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salario, salario2, diferença;
            Console.WriteLine("Digite o número relacionado ao seu cargo.");
            Console.WriteLine("1- Gerente");
            Console.WriteLine("2-Analista");
            Console.WriteLine("3-Técnico");
            Console.WriteLine("4-Outro");
            

            int menu = Convert.ToInt32(Console.ReadLine());
            

            

            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Digite seu salário ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    salario2 = salario + (salario * 10 / 100);
                    diferença = salario2 - salario;

                    Console.WriteLine("Salário antigo: " + salario);
                    Console.WriteLine("Salário novo: " + salario2);
                    Console.WriteLine("Diferença: " + diferença);
                    break;
                    case 2:
                    Console.Clear();
                    Console.WriteLine("Digite seu salário ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    salario2 = salario + (salario * 20 / 100);
                    diferença = salario2 - salario;

                    Console.WriteLine("Salário antigo: " + salario);
                    Console.WriteLine("Salário novo: " + salario2);
                    Console.WriteLine("Diferença: " + diferença);
                    break;
                    case 3:
                    Console.Clear();
                    Console.WriteLine("Digite seu salário ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    salario2 = salario + (salario * 30 / 100);
                    diferença = salario2 - salario;

                    Console.WriteLine("Salário antigo: " + salario);
                    Console.WriteLine("Salário novo: " + salario2);
                    Console.WriteLine("Diferença: " + diferença);
                    break;
                    case 4:
                    Console.Clear();
                    Console.WriteLine("Digite seu salário ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    salario2 = salario + (salario * 40 / 100);
                    diferença = salario2 - salario;

                    Console.WriteLine("Salário antigo: " + salario);
                    Console.WriteLine("Salário novo: " + salario2);
                    Console.WriteLine("Diferença: " + diferença);
                    break;
                    




            }




        }
            

        }
    }

