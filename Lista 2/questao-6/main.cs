using System;

class Program {
  public static void Main (string[] args) {
    double ap = 75, vrd = 0, vrpro = 0, ocuppro = 0, ocupn = 0, vrdif = 0;
    Console.WriteLine ("digite o valor da diaria ");
    vrd = double.Parse (Console.ReadLine());
    vrpro = vrd * 0.75;
    ocuppro = ap * 0.80;
    ocupn = ap * 0.50;
    vrdif = vrpro*ocuppro-vrd*ocupn;
    Console.WriteLine("diaria promocional é {0}", Math.Round(vrpro,2));
    Console.WriteLine("Valor arrecadado promocional é {0}", Math.Round((vrpro*ocuppro),2));
    Console.WriteLine("Valor arrecadado é {0}", Math.Round((vrd*ocupn),2));
    Console.WriteLine("a diferença é de {0}", Math.Round(vrdif,2));
  }
}