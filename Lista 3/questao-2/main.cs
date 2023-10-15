using System;

class Program {
  public static void Main (string[] args) {
    int n = 0, menor = 0, maior = 0, zero = 0, total = 0;
    char r;
    double permenor = 0, permaior = 0, perzero = 0;
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
    total = menor+maior+zero;
    permenor = (double)menor/total*100;
    permaior = (double)maior/total*100;
    perzero = (double)zero/total*100;
    Console.WriteLine ("% menor {0}", permenor);
    Console.WriteLine ("% maior {0}", permaior);
    Console.WriteLine ("% zero {0}", perzero);
  }
}