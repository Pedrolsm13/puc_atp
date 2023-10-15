using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace trabalho_final{
    internal class Cria{
        public static void rodar(int[] qtdprod, string[] prod){
            Console.WriteLine("Estoque:");
            for (int i = 0; i < 4; i++){
                Console.WriteLine(prod[i] + " - " + qtdprod[i]);
            }
        }
    }
}