using System;

class Program {
  public static void Main (string[] args) {
    double voto = 0, c1 = 0, c2 = 0, c3 = 0, c4 =0, n = 0, b = 0;
    do{
      Console.WriteLine ("digite o voto de 1 a 6 para os candidatos 1 a 4 respectivamente e 5 para nulo e 6 para branco");
      voto = double.Parse(Console.ReadLine());
      if(voto == 1)
        c1++;
      else if(voto == 2)
        c2++;
      else if(voto == 3)
        c3++;
      else if(voto == 4)
        c4++;
      else if(voto == 5)
        n++;
      else if(voto == 6)
        b++;
    }
    while(voto != 0);
    Console.WriteLine ("total de cada candidato em ordem {0} {1} {2} {3}", c1, c2, c3, c4);
    Console.WriteLine ("total de nulos {0}", n);
    Console.WriteLine ("total de brancos {0}", b);

  }
}