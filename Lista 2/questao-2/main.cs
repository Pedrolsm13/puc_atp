using System;

class Program {
  public static void Main (string[] args)
  {
    int x = 0, y = 0, z = 0, w = 0;
    Console.WriteLine ("Insira o valor do primeiro numero: ");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine ("Insira o valor do segundo numero: ");
    y = int.Parse(Console.ReadLine());

    if (x + y >= 10)
    {
      z = x + y + 5;
      Console.WriteLine("O valor é: "+ z);
    }
    else
    {
      w = x + y + 7;
      Console.WriteLine("O valor é: "+ w);
    }
    
  }
}