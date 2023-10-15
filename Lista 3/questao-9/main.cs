using System;

class Program {
  public static void Main (string[] args) {
    double pcompra = 0, pvenda = 0, qtd1 = 0, qtd2 = 0, qtd3 = 0, pctot = 0, pvtot = 0;
    Console.WriteLine ("digite o preço de compra e de venda respectivamente");
    do{
      pcompra = double.Parse(Console.ReadLine());
      if(pcompra <= 0)
        break;
        pctot += pcompra;
      pvenda = double.Parse(Console.ReadLine());
        pvtot += pvenda;
      if(pvenda < (pcompra * 1.10))
        qtd1++;
      else if(pvenda >= (pcompra * 1.10) && pvenda <= (pcompra * 1.20))
        qtd2++;
      else
        qtd3++;
    }
    while(pcompra > 0);
    Console.WriteLine ("Lucro < 10% qtd "+ qtd1);
    Console.WriteLine ("10% <= lucro <= 20% qtd "+ qtd2);
    Console.WriteLine ("Lucro > 20% qtd "+ qtd3);
    Console.WriteLine ("valor total de compra "+ pctot);
    Console.WriteLine ("valor total de venda "+ pvtot);
    Console.WriteLine ("lucro bruto total "+ (pvtot-pctot));
  }
}