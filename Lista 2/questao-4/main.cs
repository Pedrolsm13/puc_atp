using System;

class Program
{
    public static void Main(string[] args)
    {
        int anonsc = 0, anoatual = 0, idade = 0;
        string aniversario;
        Console.WriteLine("Escreva seu ano de nascimento: ");
        anonsc = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o ano atual: ");
        anoatual = int.Parse(Console.ReadLine());
        do
          {
            Console.WriteLine("ja fez aniversário? escreva em letra minúscula 'y' para sim ou 'n' para não: ");
            aniversario = Console.ReadLine();
          }
        while (aniversario != "y" && aniversario != "n");

        idade = anoatual - anonsc;

        if (aniversario == "y")
          Console.WriteLine("A idade é {0}", idade ++);
        else
          Console.WriteLine("A idade é {0}", idade);
    }
}