using System;

class Program {
  public static void Main (string[] args) {
    double salario = 0, filhos = 0, totalsal = 0, totalfil = 0, x = 0, sal100 = 0, qtd = 0;
    do{
      Console.WriteLine ("digite o salario do sujeito");
      salario = double.Parse(Console.ReadLine());
      if(salario <= 0)
        break;
      Console.WriteLine ("quantos filhos o sujeito tem?");
      filhos = double.Parse(Console.ReadLine());
      totalsal += salario;
      totalfil += filhos;
      qtd++;
      if(salario > x)
        x = salario;
      if(salario <= 100)
        sal100++;
    }
    while(salario > 0);
    
    Console.WriteLine ("a media salarial é {0}", totalsal/qtd);
    Console.WriteLine ("a media de filhos é {0}", totalfil/qtd);
    Console.WriteLine ("o maior salario é {0}", x);
    Console.WriteLine ("o percentual de salario ate 100 é {0}", sal100/qtd*100);    
  }
}