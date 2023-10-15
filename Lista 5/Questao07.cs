using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao07
    {
        public static void rodar()
        {
            int [,] matriz = new int[5, 5];
            matriz = preencher(matriz);
            questoes(matriz);
        }
        static int [,] preencher(int [,] matriz)
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++){
                    matriz[i, j] = r.Next(10, 50);
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
            return matriz;
        }
        static void questoes(int [,]matriz){
            int somal4 = 0, somac2 = 0, somadiag = 0, n = 0, somadiagsec = 0, soma = 0;
            n = matriz.GetLength(0) - 1;
            for (int i = 0; i < matriz.GetLength(0); i++){
                for (int j = 0; j < matriz.GetLength(1); j++){
                    soma += matriz[i, j];
                    if (i == 3)
                        somal4 += matriz[i, j];
                    if (j == 1)
                        somac2 += matriz[i, j];
                    if (i == j)
                        somadiag += matriz[i, j];
                    if (i + j == n)
                        somadiagsec += matriz[i, j];
                }
            }
            Console.WriteLine("Soma da linha 4 {0}", somal4);
            Console.WriteLine("Soma da coluna 2 {0}", somac2);
            Console.WriteLine("Diagonal principal {0}", somadiag);
            Console.WriteLine("Diagonal secundária {0}", somadiagsec);
            Console.WriteLine("Soma de todos os elementos {0}", soma);
        }
    }
}
