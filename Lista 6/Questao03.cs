using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao03
    {
        public static void rodar()
        {
            string frase = string.Empty, codigo = "";
            int n = 0;
            Console.WriteLine("digite a frase a ser cogificada");
            frase = Console.ReadLine();
            frase = frase.ToLower();
            for (int i = 0; i < frase.Length; i++)
            {
                n = Convert.ToInt32(frase[i]);
                if ((n >= 97 && n <= 122)){
                    n += 3;
                }
                if (n > 122){
                    n -= 26;
                }
                codigo += (char)n;
            }
            Console.WriteLine(codigo);
        }

    }
}
