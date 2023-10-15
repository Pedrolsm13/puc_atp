using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao08
    {
        public static void rodar()
        {
            int[,] matriz = new int[4, 4];
            matriz = preencher(matriz);
            questoes(matriz);
        }
        static int[,] preencher(int[,] matriz)
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(10, 50);
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
            return matriz;
        }
        static void questoes(int[,] matriz)
        {
            int somadiagab = 0;

            Console.WriteLine("abaixo a diagonal principal");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write("{0} ", matriz[i, j]);
                }
            }
            Console.WriteLine();
            for (int l = 1; l < matriz.GetLength(1); l++)
            {
                for (int k = 0; k < matriz.GetLength(0); k++)
                {
                    if (l > k)
                        somadiagab += matriz[l, k];
                }
            }
            Console.WriteLine("abaixo diagonal {0}", somadiagab);
        }
    }
}
