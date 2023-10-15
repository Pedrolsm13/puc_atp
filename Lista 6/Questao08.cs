using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao08
    {
        public static void rodar()
        {
            int qtd = 0;
            double vr = 0, fatanual = 0, fatmensal = 0, mtc = 0, multa = 0;
            Console.WriteLine("Digite a quantidade de veiculos e posteriormente o valor do aluguel");
            qtd = int.Parse(Console.ReadLine());
            vr = double.Parse(Console.ReadLine());
            StreamWriter sw = new StreamWriter("ex8.txt",false,Encoding.ASCII);
            
            fatanual = (qtd * vr * 12) / 3;
            fatmensal = fatanual / 12;
            multa = fatmensal * 0.1 * 0.2;
            mtc = qtd * 0.02 * 600;

            Console.WriteLine("O faturamento anual sem multas: {0:F2}",fatanual);
            sw.WriteLine("O faturamento anual sem multas: {0:F2}",fatanual);
            Console.WriteLine("As multas sao: {0:F2}",multa);
            sw.WriteLine("As multas sao: {0:F2}",multa);
            Console.WriteLine("o custo de manutenção medio: {0:F2}",mtc);
            sw.WriteLine("o custo de manutencao medio: {0:F2}",mtc);
            sw.Close();
        }
    }
}
