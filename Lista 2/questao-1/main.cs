using System;

class Program
{
    public static void Main(string[] args)
    {
        int n1 = 0, n2 = 0;
        Console.WriteLine("Escreva um numero inteiro: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva outro numero Inteiro: ");
        n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
            Console.WriteLine("O maior numero é " + n1);
        else
            Console.WriteLine("O maior numero é " + n2);
    }
}