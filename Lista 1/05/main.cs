using System;

class Program {
  public static void Main (string[] args)
  { 
    Double p = 0, n = 0, i = 0, vf = 0;
    Console.WriteLine("Insira o Valor da aplicação: ");
    p = Double.Parse(Console.ReadLine());
    Console.WriteLine("Isira o tempo em meses da aplicação: ");
    n = Double.Parse(Console.ReadLine());
    Console.WriteLine("Isira a taxa mensal da aplicação: ");
    i = Double.Parse(Console.ReadLine());

    i = i/100;

    vf = p*(Math.Pow((1+i),n)-1)/i;

    Console.WriteLine("No final da aplicação voce terá o valor futuro de {0}", Math.Round(vf,2));    
  }
}