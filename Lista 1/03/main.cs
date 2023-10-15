using System;

class Program
{
    public static void Main(string[] args)
    {
        //declara variaveis
        Double Kilowatt = 0, Salario = 0, VrPago = 0, VrpgDesc = 0, kW = 0, VrKw = 0;
        Console.WriteLine("Kilowatt gasto no mes: ");
        Kilowatt = Double.Parse(Console.ReadLine());
        Console.WriteLine("Salario minimo: ");
        Salario = Double.Parse(Console.ReadLine());
      
        kW =  Salario / 7;
        VrKw = kW /100;
        VrPago = Kilowatt * VrKw;
        VrpgDesc = VrPago * 0.90;
    
        Console.WriteLine("o valor do Kilowatt é " + VrKw);
        Console.WriteLine("o valor pago é " + VrPago);
        Console.WriteLine("o valor pago com desconto é " + VrpgDesc);
    }
}