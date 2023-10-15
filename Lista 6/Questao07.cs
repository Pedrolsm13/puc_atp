using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao07
    {
        public static void rodar()
        {
            int qtdletra = 0, vogais = 0;
            char letra = ' ';
            StreamWriter sw = new StreamWriter("ex7.txt",false,Encoding.ASCII);
            Console.WriteLine("Digite a quantidade de letras a ser informada");
            qtdletra = int.Parse(Console.ReadLine());
            
            
            for (int i = 1; i <= qtdletra; i++){
                Console.WriteLine("digite a letra "+ i);
                letra = Console.ReadLine()[0];
                sw.Write(letra);    
            }
            sw.Close();
            StreamReader sr = new StreamReader("ex7.txt");
            string linha = sr.ReadLine();
            foreach (char letras in linha){
                if (letras == 'a' || letras == 'e' || letras == 'i' || letras == 'o' || letras == 'u')
                vogais++;
            }
            Console.WriteLine("a quantidade de vogais =  "+ vogais);
            sr.Close();
        }
    }
}
