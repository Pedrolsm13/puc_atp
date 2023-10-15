using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao09
    {
        public static void rodar()
        {
            int[,] matriz1 = new int[4, 6];
            int[,] matriz2 = new int[4, 6];
            int[,] matriz3 = new int[4, 6];
            int[,] matriz4 = new int[4, 6];
            preencher(matriz1, matriz2);
            matriz3 = somar(matriz1, matriz2);
            matriz4 = subtrair(matriz1, matriz2);
        }
        static void preencher(int [,] matriz1,int [,] matriz2)
        {
            Random r = new Random();
            Console.WriteLine("matriz 1");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = r.Next(10, 50);
                    Console.Write("{0}\t", matriz1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("matriz 2");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz2[i, j] = r.Next(10, 50);
                    Console.Write("{0}\t", matriz2[i, j]);
                }
                Console.WriteLine();
            }
        }
        static int [,] somar(int [,] matriz1,int [,] matriz2)
        {
            int[,] matriz3 = new int[4, 6];
            Console.WriteLine("soma");
            for (int i = 0; i < matriz3.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3.GetLength(1); j++)
                {
                    matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write("{0}\t", matriz3[i, j]);
                }
                Console.WriteLine();
            }
            return matriz3;
        }

        static int [,] subtrair(int [,] matriz1,int [,] matriz2)
        {
            int[,] matriz4 = new int[4, 6];
            Console.WriteLine("subtracao");
            for (int i = 0; i < matriz4.GetLength(0); i++)
            {
                for (int j = 0; j < matriz4.GetLength(1); j++)
                {
                    matriz4[i, j] = matriz1[i, j] - matriz2[i, j];
                    Console.Write("{0}\t", matriz4[i, j]);
                }
                Console.WriteLine();
            }
            return matriz4;
        }
    }
}
