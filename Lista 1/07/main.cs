using System;

class Program {
  public static void Main (string[] args) {
    int d = 0, m = 0, a = 0, dias = 0;
    Console.WriteLine ("Quantos dias estão sem acidentes na empresa? ");
    dias = int.Parse(Console.ReadLine());

    a = dias/30/12;
    m = dias/30-a*12;
    d = dias-m*30-a*365;

    Console.WriteLine("São {0} ano, {1} mes, {2} dias", a,m,d);
    }
}