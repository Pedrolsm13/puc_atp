using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao01
    {
        public static void rodar()
        {
            int s = 20, menor = 100, pos = 0;
            int[] n = new int[s];
            Random r = new Random();
            for (int i = 0; i < s; i++){
                n [i] = r.Next(1,100);
                if (n[i] < menor){
                    menor = n[i];
                    pos = i;
                }
                Console.WriteLine("Posição {0} Valor {1}", i, n[i]);
            }
            Console.WriteLine("O menor elemento de N é {0} e sua posição dentro do vetor é {1}", menor, pos);
        }
    }
}
