using System;

class Program {
  public static void Main (string[] args) {
    int x;
    Console.WriteLine ("Digite o valor de x");
    x = int.Parse(Console.ReadLine());

    Console.WriteLine("o valor de Y é");
    
    if (x <= 1)
      Console.WriteLine(1);
    else if (x > 1 && x <= 2)
      Console.WriteLine(2);
    else if (x > 2 && x <= 3)
      Console.WriteLine(Math.Pow(x,2));
    else
      Console.WriteLine(Math.Pow(x,3));    
  }
}