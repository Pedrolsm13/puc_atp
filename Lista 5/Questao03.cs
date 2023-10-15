using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao03
    {
        public static void rodar()
        {
            Console.WriteLine("Vetor X");
            int [] x = new int[10];
            vetor(x);
        }
        static void vetor(int[] x)
        {
            Random r = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(-10, 10);
                Console.WriteLine("Posição {0} Valor {1}", i, x[i]);
            }
            vneg(x);
        }
        static void vneg(int [] x)
        {
            int n = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0) 
                n++;
            }
            int[] vtneg = new int[n];
            vtneg = vetneg(x, n);
            Console.WriteLine("Vetor de negativos");
            for (int i = 0; i < vtneg.Length; i++)
            {
                Console.WriteLine("Posição {0} Valor {1}", i, vtneg[i]);
            }
        }
        static int[] vetneg(int[] x, int n)
        {
            int[] vn = new int[n];
            n = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    vn[n++] = x[i];
                }
            }
            return vn;
        }

    }
}
