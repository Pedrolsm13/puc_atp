using System;

class Program
{
    public static void Main(string[] args)
    {
        //declara variaveis
        Double Cateto1 = 0, Cateto2 = 0, Hipotenusa = 0, Vrgiag = 0;
        Console.WriteLine("cateto1: ");
        Cateto1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("cateto2: ");
        Cateto2 = Double.Parse(Console.ReadLine());
        //Vrfdiag = (Math.Pow(BcBase,2)) + (Math.Pow(Altura,2));
        //Hipotenusa = Math.Sqrt(Vrfdiag);
        Hipotenusa = Math.Sqrt(Math.Pow(Cateto1,2) + Math.Pow(Cateto2,2));
        Console.WriteLine("a hipotenusa é " + Hipotenusa);
    }
}