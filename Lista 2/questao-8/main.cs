using System;

class Program {
  public static void Main (string[] args) {
    double salario = 0;
    int opcao = 0;
    Console.WriteLine ("Digire o salario");
    salario = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a, b ou c");    
    opcao = char.Parse(Console.ReadLine());
    
    switch (opcao){
    case 'a':
      Console.WriteLine(salario*1.08);
      break;
    case 'b':
      Console.WriteLine(salario*1.11);
      break;
    case 'c':
      if (salario <= 1000)
        salario += 350;
      else
        salario += 200;
      Console.WriteLine(salario);
      break;
    }
  }
}