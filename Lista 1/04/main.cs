using System;

class Program
{
    public static void Main(string[] args)
    {
        //declara variaveis
        Double X1 = 0, Y1 = 0, X2 = 0, Y2 = 0, Distancia = 0;
        Console.WriteLine("X1: ");
        X1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Y1: ");
        Y1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("X2: ");
        X2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Y2: ");
        Y2 = Double.Parse(Console.ReadLine());      
        Distancia = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2));
        Console.WriteLine("a distancia entre os pontos é {0}", Math.Round(Distancia,2));
    }
}