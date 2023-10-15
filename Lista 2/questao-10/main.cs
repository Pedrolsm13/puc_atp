using System;

class Program {
  public static void Main (string[] args) {
    int velomax = 0, velomotor = 0;
    Console.WriteLine ("Digite a velocidade da via");
    velomax = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a velocidade do veiculo");
    velomotor = int.Parse(Console.ReadLine());
    if (velomotor <= velomax)
      Console.WriteLine("Motorista respeitou a lei");
    else if (velomotor > velomax && velomotor <= velomax+10)
      Console.WriteLine("Multa de 50 reais");
    else if (velomotor > velomax+10 && velomotor <= velomax+30)
      Console.WriteLine("Multa de 100 reais");
    else
      Console.WriteLine("Multa de 200 reais");
  }
}