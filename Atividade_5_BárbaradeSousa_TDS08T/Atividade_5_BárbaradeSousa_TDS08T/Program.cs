using System;

namespace Atividade_5_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1) Some dois números e exiba o resultado */
            
            int num1 = 3;
            int num2 = 2;
            int soma = num1 + num2;
            Console.WriteLine("********** QUESTÃO 1 *********");
            Console.WriteLine();
            Console.WriteLine("O resultado da Soma de " + num1 + " e " + num2 + " é: " + soma);
            Console.WriteLine();

           
            /* 2) Subtraia um número por outro e exiba o resultado */
            int num3 = 7;
            int num4 = 5;
            int subtracao = num3 - num4;
            Console.WriteLine("********** QUESTÃO 2 *********");
            Console.WriteLine();
            Console.WriteLine("O resultado da Subtração de " + num3 + " e " + num4 + " é: " + subtracao);
            Console.WriteLine();

            /* 3) Multiplique 2 números e exiba o resultado */
            int num5 = 3;
            int num6 = 5;
            int multiplicacao = num5 * num6;
            Console.WriteLine("********** QUESTÃO 3 *********");
            Console.WriteLine();
            Console.WriteLine("O resultado da Multiplicação de " + num5 + " e " + num6 + " é: " + multiplicacao);
            Console.WriteLine();

            /* 4) Divida um número por outro e exiba o resultado */
            int num7 = 15;
            int num8 = 3;
            int divisao = num7 / num8;
            Console.WriteLine("********** QUESTÃO 4 *********");
            Console.WriteLine();
            Console.WriteLine("O resultado da Divisão de " + num7 + " e " + num8 + " é: " + divisao);
            Console.WriteLine();

            /* 5) Faça uma média de 3 números */
            int num9 = 5;
            int num10 = 3;
            int num11 = 7;
            float media = (num9 + num10 + num11) / 3;
            Console.WriteLine("********** QUESTÃO 5 *********");
            Console.WriteLine();
            Console.WriteLine("O resultado da média de " + num9 + ", " + num10 + " e " + num11 + " é: " + media);
            Console.WriteLine();


            /* 6) Atribua um valor a uma variável do tipo inteiro e exiba seu antecessor */
            int valor = 9;
            int antecessor = valor - 1;         
            Console.WriteLine("********** QUESTÃO 6 *********");
            Console.WriteLine();
            Console.WriteLine("O antecessor de " + valor + " é: " + antecessor);
            Console.WriteLine();

            /* 7) Atribua um valor a uma variável do tipo inteiro e exiba seu sucessor */
            int valor2 = 8;
            int sucessor = valor2 + 1;
            Console.WriteLine("********** QUESTÃO 7 *********");
            Console.WriteLine();
            Console.WriteLine("O sucessor de " + valor2 + " é: " + sucessor);
            Console.WriteLine();

            /* 8) Verifique na internet quanto está valendo o dólar e converta R$ 100,00 para dólares.  */
            float dolar = 5.67f;
            float real = 100.00f;
            float conversao = real / dolar;
            Console.WriteLine("********** QUESTÃO 8 *********");
            Console.WriteLine();
            Console.WriteLine("O valor de  " + real + " convertido para: " + dolar + " dólar é: " + conversao);
            Console.WriteLine();

            /* 9) Verifique na internet quanto está valendo o dólar e converta R$ 100,00 para dólares.  */
            float euro = 6.65f;
            float euroConverter = 100.00f;
            float reais = euro * euroConverter;
            Console.WriteLine("********** QUESTÃO 9 *********");
            Console.WriteLine();
            Console.WriteLine("O valor de  " + euroConverter + " euros convertido para reais  é: " + reais);
            Console.WriteLine();

            /* 10) Verifique na internet quanto está valendo o bitcoin e converta R$ 300,00 para bitcoin. 
                    Utilizando o Math */
            double valor_Real = 300 / 59742.66;          
            Console.WriteLine("********** QUESTÃO 10 *********");
            Console.WriteLine();
            Console.WriteLine("O valor da conversão de R$300,00 para bitcoins é: " + valor_Real);
            Console.WriteLine();



            /* 11) Faça um programa que calcule a raiz quadrada de 64. */

            int valorR = 64;
            double raiz = Math.Sqrt(valorR);
            Console.WriteLine("********** QUESTÃO 11 *********");
            Console.WriteLine();
            Console.WriteLine("O valor da raíz quadrada de " + valorR + " é: " + raiz);
            Console.WriteLine();

            /* 12) Faça um programa que calcule a potencia de 2 elevado a 128 */

            int valorP = 2;
            double resultado = Math.Pow(valorP,128);
            Console.WriteLine("********** QUESTÃO 12 *********");
            Console.WriteLine();
            Console.WriteLine("O valor da potência de " + valorP + " elevado a 128 é: " + resultado);
            Console.WriteLine();







        }
    }
}
