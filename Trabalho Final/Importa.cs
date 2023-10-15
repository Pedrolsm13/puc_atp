using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace trabalho_final{
    internal class Importa {
        public static void rodar (ref int [] qtdprod, ref string [] prod) {
            StreamReader arquivo = new StreamReader("produtos.txt");
            string linha = arquivo.ReadLine();
            int c = 0;
            while (linha!=null){
                string[] dados = linha.Split(' ');
                string codigo = dados[0];
                string quantidade = dados[1];
                qtdprod[c] = int.Parse(quantidade);
                prod[c] = codigo;
                c++;//é Csharp, não C++
                linha = arquivo.ReadLine();
            }
            arquivo.Close();
            Console.WriteLine("importado");
        }
    }
}