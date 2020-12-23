using System;
using System.Globalization;

namespace Atividade_23_2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Questão 2
            Console.Write("Entre com o número de produto: ");
            int n = int.Parse(Console.ReadLine());
            int resp = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Qual é o tipo do produto: ");
                Console.WriteLine("Digite 1 para produto");
                Console.WriteLine("Digite 2 para produto Usado");
                Console.WriteLine("Digite 3 para produto Importado");                              
                resp = int.Parse(Console.ReadLine());
                if(resp == 1)
                {
                    Produto p = new Produto();
                    Console.Write("Informe o nome do produto: ");
                    p.Nome = Console.ReadLine();
                    Console.Write("Informe o preço do produto: ");
                    p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                                   
                    Console.WriteLine(p.EtiquetadePreco());
                }
                if (resp == 2)
                {
                    ProdutoUsado p = new ProdutoUsado();
                    Console.Write("Informe o nome do produto: ");
                    p.Nome = Console.ReadLine();
                    Console.Write("Informe o preço do produto: ");
                    p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Informe a Data de Fabricação: ");
                    p.DataFabricacao = Console.ReadLine();
                    Console.WriteLine(p.EtiquetadePreco());
                }
                if (resp == 3)
                {
                    ProdutoImportado p = new ProdutoImportado();
                    Console.Write("Informe o nome do produto: ");
                    p.Nome = Console.ReadLine();
                    Console.Write("Informe o preço do produto: ");
                    p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Informe a Taxa de Alfândega: ");
                    p.TaxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine(p.EtiquetadePreco());
                }
            }
        }
    }
}
