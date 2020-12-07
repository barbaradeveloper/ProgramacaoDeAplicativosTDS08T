using System;
using System.Globalization;

namespace EstoqueDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que lê os dados de um produto em estoque (nome, preço e quantidade em estoque)

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            // Mostra os dados do produto (nome, preco, quantidade no estoque, valor total no estoque)

            double total = p.ValorTotalEmEstoque(); /* Variável criada para receber o método que calcula o total em R$ de produto no estoque */
            Console.WriteLine("Dados do produto: " + p);

            // Realizar uma entrada no estoque e mostrar novamente os dados do produto

            Console.WriteLine("Digite o número de produtos a ser adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados do produto: " + p);

            // Realizar uma saída no estoque e mostrar novamente os dados do produto

            Console.WriteLine("Digite o número de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados do produto: " + p);
            Console.ReadKey();
        }
    }
}







