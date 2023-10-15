using System;

class Program
{
    public static void Main(string[] args)
    {
        double a = 0, b = 0, x = 0;
        Console.WriteLine("Para uma equação de primeiro grau ax + b = 0, escreva a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Agora escreva b: ");
        b = double.Parse(Console.ReadLine());

        if (a == 0)
            Console.WriteLine("Nao é equação de 1º grau");

        else
        {
            x = -b / a;
            Console.WriteLine("O resultado é {0}", Math.Round(x, 2));
        }


    }
}