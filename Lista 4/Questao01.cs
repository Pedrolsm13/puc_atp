using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao01
    {
        public static void rodar()
        {
            
            int aluno;
            Console.WriteLine("Digite o numero de Alunos");
            aluno = int.Parse(Console.ReadLine());
            for (int i = 0; i < aluno; i++)
            {
                /*  if (calculo == 'A')
                       Console.WriteLine("Media aritimetica: " + Mediaa(n1, n2, n3));

                   else if (calculo == 'P')
                       Console.WriteLine("Media ponderada: " + Mediap(n1, n2, n3));

               static double Mediaa(double a, double b, double c)
               {
                   double mediaa = 0;
                   mediaa = (a + b + c) / 3;
                   return mediaa;
               }
               static double Mediap(double a, double b, double c)
               {
                   double mediap = 0;
                   mediap = (a * 5 + b * 3 + c * 2) / (5 + 3 + 2);
                   return mediap;*/
                Media();
            }
        }
                        
        static void Media()
        {
        double n1 = 0, n2 = 0, n3 = 0;
        char calculo;
        Console.WriteLine("Digite as 3 notas dos alunos");
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite A para media atritimetica e P para ponderada");
        calculo = char.Parse(Console.ReadLine());
        if (calculo == 'A')
            Console.WriteLine("Media aritimetica: " + (n1 + n2 + n3) / 3);
        else if (calculo == 'P')
            Console.WriteLine("Media ponderada: " + (n1 * 5 + n2 * 3 + n3 * 2) / (5 + 3 + 2));
        }
     }
}
