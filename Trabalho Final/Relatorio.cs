using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace trabalho_final{
    internal class Relatorio{
        public static void rodar(int[] qtdprod, string[] prod, int[,] produtos){
            StreamWriter sw = new StreamWriter("relatorio.txt", true, Encoding.ASCII);
            //relatorio.txt e console
            for (int i = 0; i < 4; i++){
                Console.Write(prod[i] + "\t");
                sw.Write(prod[i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < produtos.GetLength(0); i++){
                for (int j = 0; j < produtos.GetLength(1); j++){
                    Console.Write(produtos[i, j] + "\t");
                    sw.Write(produtos[i, j] + "\t");
                }
                Console.WriteLine();
                sw.WriteLine();
            }
            sw.WriteLine("Saldo em estoque:");
            for (int i = 0; i < 4; i++){
                Console.WriteLine(prod[i] + " - " + qtdprod[i]);
                sw.WriteLine(prod[i] + " - " + qtdprod[i]);
            }
            sw.Close();
        }
    }
}