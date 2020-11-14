using System;
using System.Globalization;

namespace SA_01_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {

            // Menu 
            Console.WriteLine("                  PADARIA PÃO DO CÉU                 ");
            Console.WriteLine();
            Console.WriteLine("          Sistema de Controle Financeiro            ");
            Console.WriteLine();
            Console.WriteLine("Escolha uma das opções do Menu: ");
            Console.WriteLine("1 - Clientes");
            Console.WriteLine("2 - Vendas");
            Console.WriteLine("3 - Produtos");
            
            int escolha = int.Parse(Console.ReadLine());
            Console.Clear(); // Limpa Tela
            
            
            if (escolha == 1)
            {

                Console.WriteLine("            CADASTRO DE CLIENTE        ");
                Console.WriteLine();
                Console.Write("Informe o nome 1° do cliente: ");
                string nomeC1 = Console.ReadLine();
                Console.Write("Informe o ID do 1° cliente: ");
                int idC1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o telefone do 1° cliente: ");
                int telefoneC1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Informe o nome 2° do cliente: ");
                string nomeC2 = Console.ReadLine();
                Console.Write("Informe o ID do 2° cliente: ");
                int idC2 = int.Parse(Console.ReadLine());
                Console.Write("Informe o telefone do 2° cliente: ");
                int telefoneC2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Informe o nome 3° do cliente: ");
                string nomeC3 = Console.ReadLine();
                Console.Write("Informe o ID do 3° cliente: ");
                int idC3 = int.Parse(Console.ReadLine());
                Console.Write("Informe o telefone do 3° cliente: ");
                int telefoneC3 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // Para exibir os clientes cadastrados 
                Console.WriteLine("         Clientes Cadastrados:      ");
                Console.WriteLine();
                Console.WriteLine("Nome: " + nomeC1 + ", ID: " + idC1 + ", Telefone: " + telefoneC1);
                Console.WriteLine("Nome: " + nomeC2 + ", ID: " + idC2 + ", Telefone: " + telefoneC2);
                Console.WriteLine("Nome: " + nomeC3 + ", ID: " + idC3 + ", Telefone: " + telefoneC3);

            }

            else if (escolha == 2)
            {
                Console.WriteLine("               CADASTRO DE VENDAS              ");
                Console.WriteLine();
                Console.Write("Data da venda: ");
                string data_venda1 = Console.ReadLine();
                Console.Write("Horário da venda: ");
                string hora_venda1 = Console.ReadLine();
                Console.Write("Produto Vendido: ");
                string produto_vendido1 = Console.ReadLine();
                Console.Write("Valor do produto: ");
                double valor_produto1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade Vendida: ");
                int qtd_vendida1 = int.Parse(Console.ReadLine());

                double valor_venda1 = valor_produto1 * qtd_vendida1;
                Console.WriteLine();


                Console.Write("Data da venda: ");
                string data_venda2 = Console.ReadLine();
                Console.Write("Horário da venda: ");
                string hora_venda2 = Console.ReadLine();
                Console.Write("Produto Vendido: ");
                string produto_vendido2 = Console.ReadLine();
                Console.Write("Valor do produto: ");
                double valor_produto2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade Vendida: ");
                int qtd_vendida2 = int.Parse(Console.ReadLine());

                double valor_venda2 = valor_produto2 * qtd_vendida1;
                Console.WriteLine();

                Console.Write("Data da venda: ");
                string data_venda3 = Console.ReadLine();
                Console.Write("Horário da venda: ");
                string hora_venda3 = Console.ReadLine();
                Console.Write("Produto Vendido: ");
                string produto_vendido3 = Console.ReadLine();
                Console.Write("Valor do produto: ");
                double valor_produto3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade Vendida: ");
                int qtd_vendida3 = int.Parse(Console.ReadLine());
                double valor_venda3 = valor_produto3 * qtd_vendida1;
                Console.WriteLine();


                // Para exibir as vendas realizadas 
                Console.WriteLine("                  Vendas Realizadas Por Cliente:               ");
                Console.WriteLine();
                Console.WriteLine("Data da Venda do 1°: " + data_venda1 + ", Hora: " + hora_venda1 + ", Produto Vendido: " + produto_vendido1
                    + ", Valor do Produto: " + valor_produto1.ToString("F2", CultureInfo.InvariantCulture) + 
                    ", Quantidade Vendida: " + qtd_vendida1 + ", Valor da Venda: " + valor_venda1.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("Data da Venda do 2° : " + data_venda2 + ", Hora: " + hora_venda2 + ", Produto Vendido: " + produto_vendido2
                    + ", Valor do Produto: " + valor_produto2.ToString("F2", CultureInfo.InvariantCulture) +
                    ", Quantidade Vendida: " + qtd_vendida2 + ", Valor da Venda: " + valor_venda2.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("Data da Venda do 3° : " + data_venda3 + ", Hora: " + hora_venda3 + ", Produto Vendido: " + produto_vendido3
                    + ", Valor do Produto: " + valor_produto3.ToString("F2", CultureInfo.InvariantCulture) + 
                    ", Quantidade Vendida: " + qtd_vendida3 + ", Valor da Venda: " + valor_venda3.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();
                // Para descobrir a maior venda

                if (valor_venda1 > valor_venda2 && valor_venda1 > valor_venda3)
                {
                    double maior_venda = valor_venda1;
                    Console.WriteLine("Maior Venda: " + maior_venda.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (valor_venda2 > valor_venda1 && valor_venda2 > valor_venda3)
                {
                    double maior_venda = valor_venda2;
                    Console.WriteLine("Maior Venda: " + maior_venda.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (valor_venda3 > valor_venda1 && valor_venda3 > valor_venda2)
                {
                    double maior_venda = valor_venda3;
                    Console.WriteLine("Maior Venda: " + maior_venda.ToString("F2", CultureInfo.InvariantCulture));
                }

                // Para descobrir a menor venda

                if (valor_venda1 < valor_venda2 && valor_venda1 < valor_venda3)
                {
                    double menor_venda = valor_venda1;
                    Console.WriteLine("Menor Venda: " + menor_venda.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (valor_venda2 < valor_venda1 && valor_venda2 < valor_venda3)
                {
                    double menor_venda = valor_venda2;
                    Console.WriteLine("Menor Venda: " + menor_venda.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (valor_venda3 < valor_venda1 && valor_venda3 < valor_venda2)
                {
                    double menor_venda = valor_venda3;
                    Console.WriteLine("Menor Venda: " + menor_venda.ToString("F2", CultureInfo.InvariantCulture));
                }

                // Para descobrir a média das vendas

                double media_vendas = valor_venda1 + valor_produto2 + valor_produto3 / 3;
                Console.WriteLine("Média das Vendas: " + media_vendas.ToString("F2", CultureInfo.InvariantCulture));

                // Para descobrir o produto mais vendido
                
                if (qtd_vendida1 > qtd_vendida2 && qtd_vendida1 > qtd_vendida3)
                {
                    string produtoMv = produto_vendido1;
                    Console.WriteLine("Produto mais vendido: " + produtoMv);
                }
                else if (qtd_vendida2 > qtd_vendida1 && qtd_vendida2 > qtd_vendida3)
                {
                    string produtoMv = produto_vendido2;
                    Console.WriteLine("Produto mais vendido: " + produtoMv);
                }
                else if (qtd_vendida3 > qtd_vendida1 && qtd_vendida3 > qtd_vendida2)
                {
                    string produtoMv = produto_vendido3;
                    Console.WriteLine("Produto mais vendido: " + produtoMv);
                }
                // Para descobrir o produto menos vendido

                if (qtd_vendida1 < qtd_vendida2 && qtd_vendida1 < qtd_vendida3)
                {
                    string produtoMev = produto_vendido1;
                    Console.WriteLine("Produto menos vendido: " + produtoMev);
                }
                else if (qtd_vendida2 < qtd_vendida1 && qtd_vendida2 < qtd_vendida3)
                {
                    string produtoMev = produto_vendido2;
                    Console.WriteLine("Produto menos vendido: " + produtoMev);
                }
                else if (qtd_vendida3 < qtd_vendida1 && qtd_vendida3 < qtd_vendida2)
                {
                    string produtoMev = produto_vendido3;
                    Console.WriteLine("Produto menos vendido: " + produtoMev);
                }




            }
            else if (escolha == 3)
            {
                Console.WriteLine("                CADASTROS DE PRODUTOS              ");
                Console.WriteLine();
                Console.Write("Nome: ");
                string nomep1 = Console.ReadLine();
                Console.Write("Quantidade Produzida: ");
                int qtd_p1 = int.Parse(Console.ReadLine());
                Console.Write("Quantidade no Estoque: ");
                int qtd_ep1 = int.Parse(Console.ReadLine());
                Console.Write("Valor : ");
                double v_p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Console.WriteLine();

                Console.Write("Nome: ");
                string nomep2 = Console.ReadLine();
                Console.Write("Quantidade Produzida: ");
                int qtd_p2 = int.Parse(Console.ReadLine());
                Console.Write("Quantidade no Estoque: ");
                int qtd_ep2 = int.Parse(Console.ReadLine());
                Console.Write("Valor : ");
                double v_p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Console.Write("Nome: ");
                string nomep3 = Console.ReadLine();
                Console.Write("Quantidade Produzida: ");
                int qtd_p3 = int.Parse(Console.ReadLine());
                Console.Write("Quantidade no Estoque: ");
                int qtd_ep3 = int.Parse(Console.ReadLine());
                Console.Write("Valor : ");
                double v_p3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Console.Clear();

                // Para exibir os produtos cadastrados 
                Console.WriteLine("                    Produtos Cadastrados:                  ");
                Console.WriteLine();
                Console.WriteLine("Nome: " + nomep1 + ", Quantidade Produzida: " + qtd_p1 + ", Quantidade no Estoque: " + qtd_ep1 
                    + ", Valor: " + v_p1.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Nome: " + nomep2 + ", Quantidade Produzida: " + qtd_p2 + ", Quantidade no Estoque: " + qtd_ep2
                    + ", Valor: " + v_p2.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Nome: " + nomep3 + ", Quantidade Produzida: " + qtd_p3 + ", Quantidade no Estoque: " + qtd_ep3
                    + ", Valor: " + v_p3.ToString("F2", CultureInfo.InvariantCulture));

            }
            
        }
    }
}
