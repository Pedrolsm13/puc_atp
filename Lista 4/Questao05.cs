using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao05
    {
        public static void rodar()
        {
            int n1 = 0, n2 = 0;
            Console.WriteLine("Digite dois numeros para calcular o mmc e mdc");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("MMC: " + MMC(n1, n2));
            Console.WriteLine("MDC: " + MDC(n1, n2));
        }
        static int MMC (int n1, int n2)
        {
            int mmc = 0;
            mmc = n1 * n2 / MDC(n1, n2);
            return mmc;
        }
        static int MDC (int n1, int n2)
        {
            int n3 = 0;
            while (n2 != 0)
            {
                n3 = n1 % n2;
                n1 = n2;
                n2 = n3;
            }
            return n1;
        }
    }
}
