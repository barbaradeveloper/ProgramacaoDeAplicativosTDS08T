using System;
using System.Globalization;

namespace _15_b_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      PROGRAMA CONTROLE DE ESTOQUE       ");
            Console.WriteLine();
            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

        }
    }
}
