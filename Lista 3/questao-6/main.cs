using System;

class Program {
  public static void Main (string[] args) {
    int n = 0;
    double s = 0, e;
    Console.WriteLine ("escreva um valor para o fim da sequencia");
    n = int.Parse(Console.ReadLine());
    for (double x = 1; x <= n; x++){
      e = 1 / x;
      Console.WriteLine (e);
      s += e;
    }
    Console.WriteLine("resultado de S = " + s);
  }
}