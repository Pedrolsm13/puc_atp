using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao03
    {
        public static void rodar()
        {
            int qtd = 0;
            Console.WriteLine("digite a quantidade de conjuntos");
            qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Conjunto(qtd);
            }
            static void Conjunto(int qtd)
            {
                int n1 = 0, n2 = 0, n3 = 0, maior, menor, media = 0;
                Console.WriteLine("digite os 3 numeros ");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                n3 = int.Parse(Console.ReadLine());
                maior = n1;
                menor = n1;
                if (n2 > maior)
                    maior = n2;
                if (n3 > maior)
                    maior = n3;
                if (n2 < menor)
                    menor = n2;
                if (n3 < menor)
                    menor = n3;
                if (n1 != maior && n1 != menor)
                    media = n1;
                else if (n2 != maior && n2 != menor)
                    media = n2;
                else if (n3 != maior && n3 != menor)
                    media = n3;
                Console.WriteLine("{0}{1}{2}", menor, media, maior);
            }
        }
    }
}
