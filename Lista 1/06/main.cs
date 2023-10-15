using System;

class Program {
  public static void Main (string[] args) {
    int x = 0, y = 0, z = 0;    
    Console.WriteLine ("Escolha o primeiro numero Real A: ");
    x = int.Parse (Console.ReadLine ());
    Console.WriteLine ("Escolha o segundo numero Real B: ");
    y = int.Parse (Console.ReadLine ());

    z = x;
    x = y;
    y = z;

    Console.WriteLine("Os valores de A e B agora são respectivamente {0} e {1}", x,y);    
  }
}