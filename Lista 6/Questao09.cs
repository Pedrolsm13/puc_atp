using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao09
    {
        public static void rodar()
        {
            int opc;
            do
            {
                Console.WriteLine("digite 1 para cadastrar e 2 para ler e 0 para sair");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                    cadastro();
                else if (opc == 2)
                    ler();
            } while (opc != 0);
        }
        static void ler()
        {
            string linha = "";
            StreamReader sr = new StreamReader("ex9.txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }
        static void cadastro()
        {
            string aluno = "", matricula = "", telefone = "";
            StreamWriter sw = new StreamWriter("ex9.txt", true, Encoding.ASCII);
            Console.WriteLine("Digite o na ordem nome, matricula e telefone");
            aluno = Console.ReadLine();
            matricula = Console.ReadLine();
            telefone = Console.ReadLine();

            sw.WriteLine("{0}\t{1}\t{2}", aluno, matricula, telefone);
            sw.Close();
        }
    }
}
