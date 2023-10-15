using System;

class Program {
  public static void Main (string[] args) {
    char simbolo;
    Console.WriteLine ("Digire um dos simbolos ('<','>' ou '=')");
    simbolo = char.Parse(Console.ReadLine());

    switch (simbolo){
    case '<':
      Console.WriteLine("SINAL DE MENOR");
      break;
    case '>':
      Console.WriteLine("SINAL DE MAIOR");
      break;
    case '=':
      Console.WriteLine("SINAL DE IGUAL");
      break;
    default:
      Console.WriteLine("OUTRO SINAL");
      break;
    }
  }
}