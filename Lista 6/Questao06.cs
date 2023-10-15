using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao06
    {
        public static void rodar()
        {
            int div = 0, somdiv = 0;
            Console.WriteLine("digite o numero para encontrar os divisores: ");
            div = int.Parse(Console.ReadLine());
            StreamWriter sw = new StreamWriter("ex6.txt",false,Encoding.ASCII);
            sw.WriteLine("o dividendo {0}", div);
            for(int x = 1; x <= div; x++) {
                if (div % x == 0){
                    Console.WriteLine(x);
                    sw.WriteLine("numro divisor = {0}", x);
                    somdiv += x;
                }
            }
            sw.WriteLine("o somatorio dos divisores = {0}", somdiv);
            sw.Close();
        }
    }
}
