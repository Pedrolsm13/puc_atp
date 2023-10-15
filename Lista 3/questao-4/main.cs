using System;

class Program {
  public static void Main (string[] args) {
    int n = 0;
    double E = 0, e, fat = 1;
    Console.WriteLine ("escreva um valor para o fim da sequencia");
    n = int.Parse(Console.ReadLine());
    for (int x = 1; x <= n; x++){
      fat *= x;
      e = 1 / fat;
      E += e;
    }
    Console.WriteLine("resultado de E = " + E);
  }
}