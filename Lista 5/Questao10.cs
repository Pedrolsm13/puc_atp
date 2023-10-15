using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao10
    {
        public static void rodar()
        {
            int[,] matriz = new int[10, 10];
            preencher(matriz);
            parametros(matriz);
            Console.WriteLine("Matriz");
        }
        static void preencher(int [,] matriz)
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                { 
                    matriz[i, j] = r.Next(10, 99);
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void parametros(int[,] matriz)
        {
            int [] aux = new int[matriz.GetLength(0)];
            int [] aux2 = new int[matriz.GetLength(0)];
            int [] aux3 = new int[matriz.GetLength(1)];
            int [] aux4 = new int[matriz.GetLength(1)];
            int [] aux5 = new int[matriz.GetLength(0)];
            int [] aux6 = new int[matriz.GetLength(0)];
            int [] aux7 = new int[matriz.GetLength(0)];
            int [] aux8 = new int[matriz.GetLength(0)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == 1)
                        aux[j] = matriz[i, j];
                    if (i == 7)
                        aux2[j] = matriz[i, j];
                    if (j == 3)
                        aux3[i] = matriz[i, j];
                    if (j == 9)
                        aux4[i] = matriz[i, j];
                    if (i == j)
                        aux5[i] = matriz[i, j];
                    if (i + j == matriz.GetLength(0) - 1)
                        aux6[i] = matriz[i, j];
                    if (i == 4)
                        aux7[j] = matriz[i, j];
                    if (j == 9)
                        aux8[i] = matriz[i, j];
                }
            }
            letraa(matriz, aux, aux2);
            letrab(matriz, aux3, aux4);
            letrac(matriz, aux5, aux6);
            letrad(matriz, aux7, aux8);
        }
        static void letraa(int [,] matriz, int [] aux, int [] aux2)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == 1)
                        matriz[i,j] = aux2[j];
                    if (i == 7)
                        matriz[i,j] = aux[j];
                }
            }
            Console.WriteLine("Letra A");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void letrab(int [,] matriz, int [] aux3, int [] aux4)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 3)
                        matriz[i,j] = aux4[i];
                    if (j == 9)
                        matriz[i,j] = aux3[i];
                }
            }
            Console.WriteLine("Letra B");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void letrac(int [,] matriz, int [] aux5, int [] aux6)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                        matriz[i,j] = aux6[i];
                    if (i + j == matriz.GetLength(0) - 1)
                        matriz[i,j] = aux5[i];
                }
            }
            Console.WriteLine("Letra C");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void letrad(int [,] matriz, int [] aux7, int [] aux8)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == 4)
                        matriz[i,j] = aux8[j];
                    if (j == 9)
                        matriz[i,j] = aux7[i];
                }
            }
            Console.WriteLine("Letra D");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
