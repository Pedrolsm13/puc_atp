using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao08
    {
        public static void rodar()
        {
            double n = 0;
            Console.WriteLine("digite o numero");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine(funcao(n));
        }
        static double funcao(double n)
        {
            double soma = 0;
            for (int i = 1; i <= n; i++)
            {
                soma += (Math.Pow(i, 2) + 1) / (i + 3);
            }
            return soma;
        }
    }
}
