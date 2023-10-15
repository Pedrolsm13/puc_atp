using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace trabalho_final{
    internal class Venda{
        public static void rodar(ref int[] qtdprod, string[] prod, ref int[,] produtos){
            int qtdvenda = 0;
            bool verifica = false;

            do {
                Console.WriteLine("Selecione o produto a ser vendido: (a,b,c,d usando os números 0,1,2,3)");
                int opc = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o dia da venda: (1 a 30)");
                int dia = int.Parse(Console.ReadLine());
                if ((dia <= 30) && (dia > 0)){
                    dia--;
                    Console.WriteLine("Quantidade vendida: ");
                    qtdvenda = int.Parse(Console.ReadLine());                
                    if (qtdvenda < qtdprod[opc]){
                        qtdprod[opc] -= qtdvenda;
                        produtos[dia, opc] = qtdvenda;
                        Console.WriteLine("Venda registrada");
                        verifica = true;
                    }
                    else{
                        Console.WriteLine("Animal, nao da pra vender mais que o estoque!");
                    }        
                }
                else{
                    Console.WriteLine("Anta, é de 0 a 30");
                }
            } while (verifica = false);
        }
    }
}