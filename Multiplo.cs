using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.Write("Digite um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if ((valor % 3) == 0 && (valor % 7) == 0)
            {
                Console.WriteLine("Múltiplo de 3 e 7.");
            }
            else
            {
                Console.WriteLine("Não é múltiplo.");
            }
            goto inicio;

        }
    }
}
