using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao07
    {
        public static void rodar()
        {
            int n = 0;
            Console.WriteLine("Digite a quantidade de alunos");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Nota();
            }
        }
        static void Nota()
        {
            int nota = 0;
            Console.WriteLine("Digite a media");
            nota = int.Parse(Console.ReadLine());
            if (nota <= 39)
                Console.WriteLine("F");
            else if (nota <= 39)
                Console.WriteLine("E");
            else if (nota > 39 && nota <=59)
                Console.WriteLine("D");
            else if (nota > 59 && nota <= 69)
                Console.WriteLine("C");
            else if (nota > 69 && nota <= 79)
                Console.WriteLine("B");
            else
                Console.WriteLine("A");
        }

    }
}
