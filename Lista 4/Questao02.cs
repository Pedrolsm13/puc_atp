using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Questao02
    {
        public static void rodar()
        {
            int qtdfilhos = 0, qtdhab = 0;
            double salario = 0;
            Console.WriteLine("digite a quantidade de habitantes");
            qtdhab = int.Parse(Console.ReadLine());
            Media(qtdhab);
        }
        static void Media(int qtdhab)
        {
            int qtdfilhos = 0;
            double saltot = 0, filtot = 0, salario = 0;
            for (int i = 0; i < qtdhab; i++)
            {
                Console.WriteLine("digite a quantidade de filhos");
                qtdfilhos = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o salario");
                salario = double.Parse(Console.ReadLine());
                saltot += salario;
                filtot += qtdfilhos;
            }
            Console.WriteLine("media salarial é " + (saltot / qtdhab));
            Console.WriteLine("media de filhos é " + (filtot / qtdhab));
        }
    }
}
