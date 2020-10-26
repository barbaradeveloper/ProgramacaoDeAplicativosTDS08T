using System;

namespace Trabalho_2_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------- QUESTÃO 1 -------------------*/


            Console.WriteLine("Entrada: ");
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            int soma = v1 + v2;
            Console.WriteLine("Saída: ");
            Console.WriteLine("SOMA = " + soma);


            /*----------------- QUESTÃO 2-------------------*/

            Console.WriteLine("Informe o valor do raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2.0);
            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));


            /*---------------------- QUESTÃO 3 -----------------------------*/

            Console.WriteLine("Informe os valores de 4 números inteiros: ");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int diferenca = (a * b) - (c * d);
            Console.WriteLine("A diferença do produto de A e B pelo produto de C e D é: " + diferenca);


            /*----------------------- QUESTÃO 4 ---------------------------*/

            Console.WriteLine("Digite o número do funcionário: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            double horasT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor recebido por hora: ");
            double valorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasT * valorH;
            Console.WriteLine("Número: " + numero);
            Console.WriteLine("Salário: " + salario.ToString("F2", CultureInfo.InvariantCulture));


            /*--------------------------- QUESTÃO 5 ----------------------------*/

            Console.WriteLine("Digite o código da peça 1: ");
            int cod1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o número de peças 1: ");
            int numP1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor unitário de cada peça 1: ");
            double vP1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Digite o código da peça 2: ");
            int cod2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o número de peças 2: ");
            int numP2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor unitário de cada peça 2: ");
            double vP2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorPago = (numP1 * vP1) + (numP2 * vP2);
            Console.WriteLine("VALOR A PAGAR: " + valorPago.ToString("F2", CultureInfo.InvariantCulture));


            /*----------------------------- QUESTÃO 6 ---------------------------------*/

            Console.WriteLine("Informe 3 valores: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double aT = (a * c) / 2;
            double aC = 3.14159 * Math.Pow(c, 2.0);
            double aTR = (a + b) * c / 2;
            double aQ = b * b;
            double aR = a * b;

            Console.WriteLine("TRIÂNGULO: " + aT.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + aC.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + aTR.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + aQ.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + aR.ToString("F3", CultureInfo.InvariantCulture));


            /*------------------------------- QUESTÃO 7 -------------------------------*/

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (num >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            /*----------------------------- QUESTÃO 8 ------------------------------*/


            Console.WriteLine("Informe um número inteiro: ");
            int num2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (num2 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }


            /*----------------------------- QUESTÃO 9 -------------------------------*/

            Console.WriteLine("Informe o valor de um número inteiro: ");
            int num3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor de outro número inteiro: ");
            int num4 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (num3 % num4 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }

            /*-------------------------- QUESTÃO 10 ----------------------------------*/
            Console.WriteLine("Insira a hora inicial: ");
            int horaI = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a hora final: ");
            int horaF = int.Parse(Console.ReadLine());
            int total = horaF - horaI;
            if (total > 24)
            {
                Console.WriteLine("Excedeu o máximo para uma partida!");
            }
            else if (total < 1)
            {
                Console.WriteLine("Tempo de jogo insuficiente");
            }

            /*------------------------------ QUESTÃO 11 --------------------------*/

            Console.WriteLine("Informe o código do item: ");
            int cod = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a quantidade desejada: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result;
            if (cod == 1)
            {
                result = qtd * 4.00;
                Console.WriteLine("Total: " + result.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 2)
            {
                result = qtd * 4.50;
                Console.WriteLine("Total: " + result.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 3)
            {
                result = qtd * 5.00;
                Console.WriteLine("Total: " + result.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 4)
            {
                result = qtd * 2.00;
                Console.WriteLine("Total: " + result.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 5)
            {
                result = qtd * 1.50;
                Console.WriteLine("Total: " + result.ToString("F2", CultureInfo.InvariantCulture));
            }

            /*-------------------------- QUESTÃO 12 ------------------------------*/

            Console.WriteLine("Informe um valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor >= 0 && valor < 25)
            {
                Console.WriteLine("O valor se encontra no intervalo: [0,25]");
            }
            else if (valor >= 25 && valor < 50)
            {
                Console.WriteLine("O valor se encontra no intervalo: [25,50]");
            }
            else if (valor >= 50 && valor < 75)
            {
                Console.WriteLine("O valor se encontra no intervalo: [50,75]");
            }
            else if (valor >= 75 && valor <= 100)
            {
                Console.WriteLine("O valor se encontra no intervalo: [75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }


            /*------------------------ QUESTÃO 13 ---------------------------*/
            Console.WriteLine("Insira a posição para o eixo X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a posição para o eixo Y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Esta presente no primeiro quadrante!");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Esta presente no segundo quadrante!");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Esta presente no terceiro quadrante!");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Esta presente no quarto quadrante!");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Esta na origem!");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Esta no eixo Y!");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Esta no eixo X!");
            }
            /*------------------------ QUESTÃO 14 ---------------------------*/
            Console.WriteLine("Digite o valor do salario: ");
            double salario = double.Parse(Console.ReadLine());
            double imposto = 0;
            if (salario > 2000)
            {
                Console.WriteLine("Isento!");
            }
            else if (salario < 3000)
            {
                imposto = (salario - 2000) * 0.08;
                Console.WriteLine($"O total a ser pago é: {imposto}");
            }
            else if (salario < 4500)
            {
                imposto = (salario - 3000) * 0.18 + (1000 * 0.8);
                Console.WriteLine($"O total a ser pago é: {imposto}");
            }
            else if (salario > 4500)
            {
                imposto = (salario - 4500) * 0.28 + (1000 * 0.8) + (1000 * 0.18);
                Console.WriteLine($"O total a ser pago é: {imposto}");
            }


            /*------------------------- QUESTÃO 15 -------------------------*/
            string senhaC = "2002";
            Console.WriteLine("Programa que retorna se a senha é correta");
            bool senha = false;

            while (senha == false)
            {
                Console.WriteLine("Insira a senha: ");
                string q15 = Console.ReadLine();

                if (q15 == senhaC)
                {
                    Console.WriteLine("Acesso permitido");
                    senha = true;
                }
                else
                {
                    Console.WriteLine("Senha invalida");
                    senha = false;
                }

            }


            /* ------------------------------ QUESTÃO 16 ------------------------------------*/
            Console.WriteLine("Insira a posição para o eixo X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a posição para o eixo Y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Esta presente no primeiro quadrante!");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Esta presente no segundo quadrante!");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Esta presente no terceiro quadrante!");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Esta presente no quarto quadrante!");
            }

            /* ------------------------------ QUESTÃO 17 ------------------------------------*/
            Console.WriteLine("Insira o codigo do combustivel que deseja abastecer: ");
            int cod = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            bool cont = true;

            while (cont == true)
            {

                while (cod != 4)
                {

                    Console.WriteLine("Insira o codigo referente a sua preferencia de combustivel ");
                    Console.WriteLine("1.Álcool");
                    Console.WriteLine("2.Gasolina ");
                    Console.WriteLine("3.Diesel");
                    Console.WriteLine("4.Fim");

                    int cod = int.Parse(Console.ReadLine());
                    if (cod == 1)
                    {
                        alcool++;
                    }

                    else if (cod == 2)
                    {
                        gasolina++;

                    }

                    else if (cod == 3)
                    {
                        diesel++;
                    }
                    else if (cod == 4)
                    {
                        Console.WriteLine("Muito Obrigado!");
                    }

                    else
                    {
                        Console.WriteLine("Codigo invalido! Tente novamente.");
                    }
                }


                /*---------------------------- QUESTÃO 18 ---------------------------------*/

                Console.WriteLine("Informe um valor inteiro: ");
                int x = int.Parse(Console.ReadLine());
                for (int n = 0; n <= x; n++)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(n);
                    }
                }


                /*------------------------------- QUESTÃO 19 --------------------------------*/

                Console.WriteLine("Digite um valor inteiro: ");
                int n = int.Parse(Console.ReadLine());

                for (int x = 0; x <= n; x++)
                {
                    if (n >= 10 && n <= 20)
                    {
                        Console.WriteLine($"{n} in");
                    }
                    else
                    {
                        Console.WriteLine($"{n} out");
                    }
                }

                /*------------------------------ QUESTÃO 20 -------------------------------------*/

                Console.WriteLine("Digite o número de casos de teste: ");
                int n = int.Parse(Console.ReadLine());

                for (int x = 1; x <= n; x++)
                {
                    Console.WriteLine("Digite os valores do  caso de teste: ");
                    double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double v3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double r1 = (v1 * 2) + (v2 * 3) + (v3 * 5) / 10;
                    Console.WriteLine(r1.ToString("F1", CultureInfo.InvariantCulture));
                }

                /*------------------------- QUESTÃO 21 --------------------------------*/

                Console.WriteLine("Digite um número: ");
                int n = int.Parse(Console.ReadLine());
                for (int x = 1; x <= n; x++)
                {
                    Console.WriteLine("Digite um número: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro número: ");
                    double n2 = double.Parse(Console.ReadLine());

                    double result = n1 / n2;
                    if (n2 == 0)
                    {
                        Console.WriteLine("Divisão Impossível");
                    }
                    else
                    {
                        Console.WriteLine(result);
                    }
                }



                /*------------------------------ QUESTÃO 23 --------------------------------------*/

                Console.WriteLine("Digite um número: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                /*------------------------------ QUESTÃO 24------------------------------------*/

                Console.WriteLine("Digite um número inteiro positivo: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i + Math.Pow(i, 2.0) + Math.Pow(i, 3.0));
                }
            }
    }
}
