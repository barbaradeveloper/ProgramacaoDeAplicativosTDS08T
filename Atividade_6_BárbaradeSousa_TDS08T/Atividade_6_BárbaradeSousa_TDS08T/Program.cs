using System;
using System.Globalization;

namespace Atividade_6_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Questão 1             
             Um programa onde solicite os dados de três pessoas e em seguida exiba os dados na frase. 
                a) Nome
                b) gênero
                c) Telefone
                d) Saldo Bancário
            */
            
            Console.WriteLine("----------- QUESTÃO 1 -------------");
            
            // Entrada de Dados
            Console.Write("Digite o nome da 1° pessoa: ");
            string nome1 = Console.ReadLine();
            Console.Write("Digite o genêro da 1° pessoa: ");
            string genero1 = Console.ReadLine();
            Console.Write("Digite o telefone da 1° pessoa: ");
            int telefone1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o saldo bancário da 1° pessoa: ");
            double saldo1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o nome da 2° pessoa: ");
            string nome2 = Console.ReadLine();
            Console.Write("Digite o genêro da 2° pessoa: ");
            string genero2 = Console.ReadLine();
            Console.Write("Digite o telefone da 2° pessoa: ");
            int telefone2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o saldo bancário da 2° pessoa: ");
            double saldo2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o nome da 3° pessoa: ");
            string nome3 = Console.ReadLine();
            Console.Write("Digite o genêro da 3° pessoa: ");
            string genero3 = Console.ReadLine();
            Console.Write("Digite o telefone da 3° pessoa: ");
            int telefone3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o saldo bancário da 3° pessoa: ");
            double saldo3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Saída de dados
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Contato 01 - " + nome1 + ", o telefone é " + telefone1 + ". Saldo bancário: R$" + saldo1 +" reais");
            Console.WriteLine("Contato 02 - " + nome2 + ", o telefone é " + telefone2 + ". Saldo bancário: R$" + saldo2 + " reais");
            Console.WriteLine("Contato 03 - " + nome3 + ", o telefone é " + telefone3 + ". Saldo bancário: R$" + saldo3 + " reais");
            

            /* Questão 2 
             Solicite ao usuário que entre com dois valores
               a) mostre a soma dos dois valores
               b) mostre a multiplicação dos dois valores
               c) multiplique os dois valores e divida pelo segundo valor
               d) multiplique os dois valores e subtraia pelo primeiro valor            
             */
            // Entrada de dados 
             Console.Write("Digite um valor: ");
             double valor1 = double.Parse(Console.ReadLine());
             Console.Write("Digite outro valor: ");
             double valor2 = double.Parse(Console.ReadLine());
             Console.WriteLine("----------------------------------------------------------");


             // Saída de dados 

             double mult = valor1 * valor2;
             double result1 = (valor1 * valor2) / valor2;
             double result2 = (valor1 * valor2) - valor1;
             Console.WriteLine("O resultado da multiplicação de " + valor1 + " x " + valor2 + " é igual a: " + mult);
             Console.WriteLine("O resultado da multiplicação de " + valor1 + " x " + valor2 + " / por " + valor2 + " é igual a: " + result1);
             Console.WriteLine("O resultado da multiplicação de " + valor1 + " x " + valor2 + " - " + valor1 + " é igual a: " + result2);

            /* Questão 3 
             Faça um programa que exiba a tabuada de multiplicação do número 1.
             Obs. Utilize para isso variáveis do tipo int e algum dos três métodos de junção (Placeholders, concatenação e interpolação)  
            */
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int n4 = 4;
            int n5 = 5;
            int n6 = 6;
            int n7 = 7;
            int n8 = 8;
            int n9 = 9;
            int n10 = 10;

            int r1 = n1 * n1;
            int r2 = n1 * n2;
            int r3 = n1 * n3;
            int r4 = n1 * n4;
            int r5 = n1 * n5;
            int r6 = n1 * n6;
            int r7 = n1 * n7;
            int r8 = n1 * n8;
            int r9 = n1 * n9;
            int r10 = n1 * n10;

            Console.WriteLine("Tabuada de multiplicação do número 1:");
            Console.WriteLine();
            Console.WriteLine(n1 + " x " + n1 + " = " + r1);
            Console.WriteLine(n1 + " x " + n2 + " = " + r2);
            Console.WriteLine(n1 + " x " + n3 + " = " + r3);
            Console.WriteLine(n1 + " x " + n4 + " = " + r4);
            Console.WriteLine(n1 + " x " + n5 + " = " + r5);
            Console.WriteLine(n1 + " x " + n6 + " = " + r6);
            Console.WriteLine(n1 + " x " + n7 + " = " + r7);
            Console.WriteLine(n1 + " x " + n8 + " = " + r8);
            Console.WriteLine(n1 + " x " + n9 + " = " + r9);
            Console.WriteLine(n1 + " x " + n10 + " = " + r10);

            /* Questão 4 */

            // Entrada de dados 
            Console.Write("Entre com seu nome completo: ");
            string nomeC = Console.ReadLine();
            Console.Write("Quantos quartos tem na sua casa? ");
            int qtd = int.Parse(Console.ReadLine());
            Console.Write("Entre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine());

            // Saída de dados 
            Console.WriteLine(nomeC);
            Console.WriteLine(qtd);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));












        }
    }
}
