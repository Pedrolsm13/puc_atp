using System;

class Program {
  public static void Main (string[] args) {
    int c = 0, d = 0, u = 0, cdu = 0, udc = 0, A = 0, B = 0, C = 0, D = 0, nc = 0, nd = 0, nu = 0;
    Console.WriteLine ("Nessa atividade devemos usar apenas numeros de 3 digitos");
    
    do
    {
      Console.WriteLine ("Escolha um número entre 100 e 999: ");
      cdu = int.Parse(Console.ReadLine());
      
      if (cdu < 100 || cdu > 999)
        {
          Console.WriteLine("O numero deve estar ente 100 e 999");
        }
    }
    while (cdu < 100 || cdu > 999);

    u = cdu % 10;
    d = cdu % 100/10;
    c = cdu / 100;
    udc = u*100+d*10+c;
    A = cdu + udc;
    nu = A % 10;
    nd = A % 100/10;
    nc = A / 100;
    //letra b é a formula abaixo
    C = nc * 1 + nd * 2 + nc * 3;

    D = C % 10;
    
    Console.WriteLine("Letra a = {0}",A);
    Console.WriteLine("Letra b é representada pela formula presente no algoritimo: nc * 1 + nd * 2 + nc * 3;");
    Console.WriteLine("Letra c = {0}",C);
    Console.WriteLine("Letra d = {0}",D);
  }
}