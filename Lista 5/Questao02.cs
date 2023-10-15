using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Questao02
    {
        public static void rodar()
        {
            int aluno = 10;
            notas(aluno);
        }
        static void notas(int aluno)
        {
            int[] n = new int[aluno];
            Random r = new Random();
            for (int i = 0; i < aluno; i++)
            {
                n[i] = r.Next(1, 10);
                Console.WriteLine("Aluno {0} Nota {1}", i, n[i]);
            }
            calc(n);
        }
        static void calc(int [] n){
            int a = 0, m = 0;
            for (int i = 0; i < n.Length; i++)
            {
                m += n[i];
                if (n[i] >= 6)
                {   
                    a++;
                }
            }
            Console.WriteLine("A média das notas dos alunos {0}", (double)m/n.Length);
            Console.WriteLine("A quantidade de alunos que tiraram nota maior que 6 é {0}", a);
        }
    }
}
