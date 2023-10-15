using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao06
    {
        public static void rodar()
        {
            int[] vetor = new int[31];
            vetor = preencher(vetor);
            escreve(vetor);
        }
        static int[] preencher(int[] vetor)
        {
            Random r = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(15, 40);
            }
            return vetor;
        }
        static void escreve(int[] vetor)
        {
            int maior = 15, menor = 40, media = 0, inferior = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("dia {0} Temperatura {1}°", i, vetor[i]);
                if (vetor[i] > maior){
                    maior = vetor[i];}
                if (vetor[i] < menor){
                    menor = vetor[i];}
                media += vetor[i];
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < (media / vetor.Length))
                    inferior++;
            }
            Console.WriteLine("Maior temperatura {0}°", maior);
            Console.WriteLine("Menor temperatura {0}°", menor);
            Console.WriteLine("Média das temperaturas {0}°", media / vetor.Length);
            Console.WriteLine("Dias com temperatura inferior a média {0}", inferior);
        }
}
}
