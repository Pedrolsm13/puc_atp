using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao02
    {
        public static void rodar()
        {
            string frase = string.Empty, nova_frase = "";
            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();
            frase = frase.ToLower();
            for (int i = 0; i < frase.Length; i++){
                if (!(frase[i] == 'a'|| frase[i] == 'e'|| frase[i] == 'i'|| frase[i] == 'o'|| frase[i] == 'u'))
                nova_frase += frase[i];
            }
            Console.WriteLine(nova_frase);
        }
    }
}
