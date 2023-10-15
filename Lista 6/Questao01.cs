using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao01
    {
        public static void rodar()
        {
            string frase;
            int cont = 0;
            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    cont++;
                }
            }
            Console.WriteLine("A frase tem {0} espaços em branco", cont);
        }
    }
}
