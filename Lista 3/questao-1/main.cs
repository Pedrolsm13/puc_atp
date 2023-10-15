using System;

class Program {
  public static void Main (string[] args) {
    int n = 0, menor = 0, maior = 0, zero = 0;
    char r;
    do{
      Console.WriteLine ("digite um numero inteiro");
      n = int.Parse(Console.ReadLine());
      if (n < 0)
        menor++;
      else if (n > 0)
        maior++;
      else
        zero++;
      Console.WriteLine("deseja continuar pressione s");
      r = char.Parse(Console.ReadLine());      
    }
    while (r == 's');
    Console.WriteLine ("menor {0}",menor);
    Console.WriteLine ("maior {0}",maior);
    Console.WriteLine ("zero {0}",zero);
  }
}