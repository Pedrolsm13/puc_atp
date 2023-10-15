using System;

class Program {
  public static void Main (string[] args) {
    int nota = 0;
    Console.WriteLine ("Digite a nota de 0 a 10");
    nota = int.Parse(Console.ReadLine());
    
      if (nota < 0)
        Console.WriteLine("erro");
      else if (nota >= 0 && nota < 5)
        Console.WriteLine("Insatisfatório");
      else if (nota >= 5 && nota < 7)
        Console.WriteLine("Regular");
      else if (nota >= 7 && nota < 8)
        Console.WriteLine("Bom");
      else if (nota >= 8 && nota <= 10)
        Console.WriteLine("Otimo");
      else
        Console.WriteLine("erro");
  }  
}