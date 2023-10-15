using System;

class Program
{
    public static void Main(string[] args)
    {
        //declara variaveis
        Double BcBase = 0, Perimetro = 0, Altura = 0, Area = 0, Diagonal = 0, Vrfdiag = 0;
        Console.WriteLine("base do retangulo: ");
        BcBase = Double.Parse(Console.ReadLine());
        Console.WriteLine("altura do retangulo: ");
        Altura = Double.Parse(Console.ReadLine());
        Area = BcBase * Altura;
        Console.WriteLine("a area é igual a " + Area);
        Perimetro = BcBase * Altura * 2;
        Console.WriteLine("o perimetro é " + Perimetro);
        //Vrfdiag = (Math.Pow(BcBase,2)) + (Math.Pow(Altura,2));
        //Diagonal = Math.Sqrt(Vrfdiag);
        Diagonal = Math.Sqrt(Math.Pow(BcBase,2) + Math.Pow(Altura,2));
        Console.WriteLine("a diagonal é {0:f2} ", Diagonal);
    }
}
