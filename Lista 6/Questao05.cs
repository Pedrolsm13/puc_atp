using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao05
    {
        public static void rodar()
        {
            int c = 0;
            StreamReader sr = new StreamReader("ex4.txt");
            string linha = sr.ReadLine();
            while (linha != null){
                Console.WriteLine(linha);
                c++;
                linha = sr.ReadLine();
            }
            Console.WriteLine("a quantidade de linhas no arquivo é: "+ c);
            sr.Close();
        }
    }
}

