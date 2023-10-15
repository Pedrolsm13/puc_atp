using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace trabalho_final{
    internal class Program {
        public static void Main (string[] args) {
            int[] qtdprod = new int[4];
            string[] prod = new string[4];
            int [,] produtos = new int [30,4];
            int op = 0;
            do {
                Console.WriteLine ("1 - Importar arquivo de produtos");
                Console.WriteLine ("2 - Registrar Vendas");
                Console.WriteLine ("3 - Relatório de estoque");
                Console.WriteLine ("4 - Criar arquivo de vendas");
                Console.WriteLine ("5 - Sair");
                Console.WriteLine ("Digite a opção");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine ("Legal!!!!");   
                if(op == 1)
                    Importa.rodar(ref qtdprod, ref prod);
                else if(op == 2)
                    Venda.rodar(ref qtdprod, prod, ref produtos);
                else if(op == 3)
                    Cria.rodar(qtdprod, prod);
                else if(op == 4)
                    Relatorio.rodar(qtdprod, prod, produtos);
            } while (op != 5);
        }
    }
}