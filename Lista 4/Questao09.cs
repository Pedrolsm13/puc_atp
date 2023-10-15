using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao09
    {
        public static void rodar()
        {
            int qtd = 0;
            Console.WriteLine("digite a quantidade de alunos");
            qtd = int.Parse(Console.ReadLine());
            Console.WriteLine(Mediaalunos(qtd));
        }
        static double Mediaalunos(int qtd)
        {
            double media = 0, totnota = 0, c = 0;
            for (int i = 0; i < qtd; i++)
            {
                double nota = 0;
                Console.WriteLine("digite a nota do aluno");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 6)
                {
                    c++;
                    totnota += nota;
                }
            }
            media = totnota / c;
            return media;
        }
    }
}
