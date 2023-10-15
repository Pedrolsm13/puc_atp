using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao04
    {
        public static void rodar()
        {
            int [] x = new int[10];
            int [] y = new int[10];
            vetor(x, y);
        }
        static void vetor(int [] x, int [] y)
        {
            Random r = new Random();
            Console.WriteLine("Vetor 1");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(0, 100);
                Console.WriteLine("Posição {0} Valor {1}", i, x[i]);
            }
            Console.WriteLine("Vetor 2");
            for (int j = 0; j < y.Length; j++)
            {
                y[j] = r.Next(0, 100);
                Console.WriteLine("Posição {0} Valor {1}", j, y[j]);
            }
            novovetor(x, y);
        }
        static void novovetor(int [] x, int [] y)
        {
            int [] z = new int[20];
            z = intercalado(x, y);
            Console.WriteLine("Vetor total");
            for (int k = 0; k < z.Length; k++)
            {
                Console.WriteLine("Posição {0} Valor {1}", k, z[k]);
            }
        }
        static int[] intercalado(int[] x, int[] y)
        {
            int[] z = new int[20];
            int n = 0;
            for (int i = 0; i < x.Length; i++)
            {
                z[n] = x[i];
                n += 2;
            }
            n = 1;
            for (int j = 0; j < y.Length; j++)
            {
                z[n] = y[j];
                n += 2;
            }
            return z;
        }
    }
}
