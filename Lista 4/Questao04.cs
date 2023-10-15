using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao04
    {
        public static void rodar()
        {
            int qtd = 0;
            Console.WriteLine("escreva a quantidade de triangulos");
            qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Conjunto(qtd);
            }
        }
        static void Conjunto(int qtd)
        {
            double l1 = 0, l2 = 0, l3 = 0;
            Console.WriteLine("digite os 3 lados do triangulo");
            l1 = double.Parse(Console.ReadLine());
            l2 = double.Parse(Console.ReadLine());
            l3 = double.Parse(Console.ReadLine());
            if (l1 < l2 + l3 && l2 < l1 + l3 && l3 < l1 + l2)
            {
                if ((l1 == l2) && (l2 == l3))
                    Console.WriteLine("Equilátero");
                else if (l1 == l2 || l1 == l3 || l2 == l3)
                    Console.WriteLine("Isoceles");
                else
                    Console.WriteLine("Escaleno");
            }
            else
                Console.WriteLine("Não é triângulo");
        }
    }
}
