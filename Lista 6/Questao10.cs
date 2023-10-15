using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao10
    {
        public static void rodar()
        {
            double num = 0, valor = 0, c = 0, total = 0, min = 900, max = 0, media = 0;
            StreamWriter sw = new StreamWriter("ex10.txt",false,Encoding.ASCII);
            Random r = new Random();
            for (int i = 0; i < 20; i++){
                num = r.Next(100,900);
                num += r.NextDouble();
                sw.WriteLine(num);
            }
            sw.Close();

            StreamReader sr = new StreamReader("ex10.txt");
            string linha = sr.ReadLine();
            while(linha != null){
            valor = double.Parse(linha);
            c++;
            total += valor;
            if (min >= valor){
                min = valor;
            }
            if (max <= valor){
                max = valor;
            }
            linha = sr.ReadLine();
            }
            media = total / c;
            Console.WriteLine("Maximo: "+ max);
            Console.WriteLine("Minimo: "+ min);
            Console.WriteLine("Media: "+ media);
            sr.Close();
        }
    }
}
