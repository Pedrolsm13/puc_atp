using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao05
    {
        public static void rodar()
        {
            int[] vet = new int[3];
            vet = sorteio(vet);
            tentativa(vet);
        }
        static int[] sorteio(int[] vet)
        {
            Random r = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = r.Next(10, 50);
                Console.WriteLine("Posição {0} Valor {1}", i, vet[i]);
            }
            return vet;
        }
        static void tentativa(int[] vet)
        {
            Console.WriteLine("Tente acertar os valores");
            bool acertou = false;
            int tent;
            while (!acertou)
            {
                tent = int.Parse(Console.ReadLine());
                acertou = confere(vet, tent);
                if (acertou)
                    Console.WriteLine("Você acertou");
                else
                    Console.WriteLine("Você errou");
            }
            static bool confere(int[] vet, int tent)
            {
                for (int i = 0; i < vet.Length; i++)
                {
                    if (tent == vet[i])
                        return true;
                }
                return false;
            }
        }
    }
}

