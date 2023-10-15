using System;

class Program {
  public static void Main (string[] args) {
    int n1 = 1, n2 = 1, n3, n = 0;
    Console.WriteLine("Digite o numero de elementos");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("1\n1");
        for (int x = 0; x < n; x++)
        {
          n3 = n1 + n2;
          if(n3 >= n)
            break;
          Console.WriteLine(n3);
          n1 = n2;
          n2 = n3;
        }
  }
}