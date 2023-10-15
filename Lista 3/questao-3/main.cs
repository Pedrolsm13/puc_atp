using System;

class Program {
  public static void Main (string[] args) {
    int n = 0, nt = 0, d = 0, c = 0;
    Console.WriteLine ("digite 10 numeros inteiros");
    for (int x = 0; x < 10; x++){
      n = int.Parse(Console.ReadLine());
      if(n % 3 == 0 && n % 9 == 0)
        nt++;
      else if(n % 2 == 0)
        d++;
      else if(n % 5 == 0)
        c++;
      else
        Console.WriteLine("Número não é divisível pelos valores");
    }
    Console.WriteLine("divisiveis por 3 e 9 qtd " + nt);
    Console.WriteLine("divisiveis por 2 qtd " + d);
    Console.WriteLine("divisiveis por 5 qtd " + c);
  }
}