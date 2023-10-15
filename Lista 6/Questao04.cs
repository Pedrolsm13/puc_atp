using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lista6
{
    internal class Questao04
    {
        public static void rodar()
        {
            int c = 0;
            StreamReader a = new StreamReader("ex4.txt");
            String Line = a.ReadLine();
            while (Line != null){
                for(int i = 0; i < Line.Length; i++){
                    if (Line[i] == 'a')
                    c++;
                }
                Line = a.ReadLine();
            }
            Console.WriteLine("a letra 'a' aparece {0} vezes", c);
            a.Close();
        }
    }
}
