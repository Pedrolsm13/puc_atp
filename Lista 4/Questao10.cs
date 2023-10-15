using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao10
    {
        public static void rodar()
        {
            int n = 0;
            Console.WriteLine("Digite a idade do nadador");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Categoria(n));
        }
        static char Categoria(int n)
        {
            char categoria;
            if (n >= 5 && n <= 7)
                categoria = 'F';
            else if (n >= 8 && n <= 10)
                categoria = 'E';
            else if (n >= 11 && n <= 13)
                categoria = 'D';
            else if (n >= 14 && n <= 15)
                categoria = 'C';
            else if(n >= 16 && n <= 17)
                categoria = 'B';
            else
                categoria = 'A';
            return categoria;
        }
    }
}
