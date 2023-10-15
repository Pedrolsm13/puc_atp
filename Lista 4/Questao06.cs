using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao06
    {
        public static void rodar()
        {
            int qtd = 0, n = 0;
            Console.WriteLine("escreva a quantidade de numeros");
            qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("digite o numero");
                n = int.Parse(Console.ReadLine());
                if (Pos(n) == true)
                    Console.WriteLine("Positivo");
                else if (Pos(n) == false && n != 0)
                    Console.WriteLine("Negativo");
            }
        }
        static bool Pos(int p)
        {
            bool positivo;
            positivo = p > 0;
            return positivo;
        }
    }
}
