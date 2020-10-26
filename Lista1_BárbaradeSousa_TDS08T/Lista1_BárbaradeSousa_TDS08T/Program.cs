using System;
using System.Globalization;

namespace Lista1_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Console.WriteLine("----------------- Questão 1 -------------------");
           Console.WriteLine();
           Console.Write("Digite um número: ");
           int n1 = int.Parse(Console.ReadLine());
           n1++;
           Console.WriteLine("O sucessor desse número é: " + n1);
        

            /* Questão 2 */
           
            Console.WriteLine("---------------- QUESTÃO 2 -------------------");
            Console.Write("Digite a nota da primeira prova: ");
            float p1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            float p2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota da terceira prova: ");
            float p3 = float.Parse(Console.ReadLine());

            float media = (p1 + p2 + p3) / 3;
            if (media < 5)
            {
                Console.WriteLine("A média das notas do aluno é " + media + " e sua situação é Reprovado");
            }
            else if (media < 7)
            {
                Console.WriteLine("A média das notas do aluno é " + media + " e sua situação é Recuperação");
            }
            else if (media >= 7)
            {
                Console.WriteLine("A média das notas do aluno é " + media + " e sua situação é Aprovado");
            }
           

            /* Questão 3 */
           
            Console.WriteLine("-------------- Questão 3 --------------");
            Console.WriteLine();
            Console.Write("Digite o número de anos que o fumante fuma: ");
            int anos = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de cigarros fumados por dia: ");
            int numC = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço de uma carteira: ");
            float precoC = float.Parse(Console.ReadLine());

            float gastoC = (numC * 365 * anos * precoC);
            Console.WriteLine("A quantidade de dinheiro gasta pelo fumante é de: " + gastoC);
           

            /* Questão 4 */
          
            Console.WriteLine("------------------- QUESTÃO 4 ----------------");
            Console.WriteLine();
            Console.Write("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            int y = int.Parse(Console.ReadLine());
            int quociente = x / y;
            int resto = x % y;
            Console.WriteLine("O quociente da divisão de " + x + " por " + y + " é " + quociente + " e o resto é " + resto);
       
            /*------------------------------------ QUESTÃO 5 ---------------------------------------*/
          
            Console.Write("Informe o valor da altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Ab = 3.14 * Math.Pow(raio, 2.0);
            double Al = 2 * 3.14 * raio * altura;
            double At = 2 * Ab + Al;

            double volume = Ab * altura;

            Console.WriteLine("A área da base do cilindro é: " + Ab.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A área lateral do cilindro é: " + Al.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A área total do cilindro é: " + At.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O volume do cilindro é: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            /*---------------------------- QUESTÃO 6 ----------------------------*/
           
            Console.Write("Informe um valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe outro valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = valor1 + valor2;
            double produto = valor1 * valor2;
            double quociente = valor1 / valor2;

            Console.WriteLine("A soma de " + valor1 + " e " + valor2 + " é igual a: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O produto de " + valor1 + " e " + valor2 + " é igual a: " + produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O quociente de " + valor1 + " e " + valor2 + " é igual a: " + quociente.ToString("F2", CultureInfo.InvariantCulture));
           
            /*---------------------------- QUESTÃO 7 ----------------------------*/
          
            Console.Write("Informe o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o terceiro valor: ");
            double v3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = v2 + v3;

            if (v1 > soma)
            {
                Console.WriteLine("O primeiro valor é maior que a soma do segundo com o terceiro valor.");
            }
            else
            {
                Console.WriteLine("O primeiro valor não é maior que a soma do segundo com o terceiro valor.");
            }
           
            /*----------------------------- QUESTÃO 8 -------------------------*/
           
            Console.Write("Informe a razão da PA - Progressão Aritmética: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Informe o primeiro termo:");
            int pT = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ultimo termo: ");
            int pS = int.Parse(Console.ReadLine());
          
            /*------------------------------ QUESTÃO 9 ----------------------*/
          
            Console.Write("Informe um nome: ");
            string nome = Console.ReadLine();
            if (nome == "Bárbara")
            {
                Console.WriteLine("NOME CORRETO");
            }
            else
            {
                Console.WriteLine("NOME INCORRETO");
            }
           
            /*------------------------ QUESTÃO 10 --------------------------*/
         
            Console.Write("Informe o valor inteiro de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor inteiro de B: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A é maior que B.");
            } else if (b > a)
            {
                Console.WriteLine("B é maior que A.");
            } else if (a == b)
            {
                Console.WriteLine("A = B");
            }
            
            /*-------------------------- QUESTÃO 11 ----------------------*/
         
            Console.Write("Informe o preço do carro: ");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = p * 45 / 100;
            double lucro = p * 12/100;

            Console.WriteLine("O imposto a ser pago é de " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O lucro do distribuidor é de " + lucro.ToString("F2", CultureInfo.InvariantCulture));
            
            /*---------------------- QUESTÃO 12 -----------------------*/
           
            Console.Write("Informe a velocidade máxima permitida na avenida: ");
            int vM = int.Parse(Console.ReadLine());
            Console.Write("Informe a velocidade percorrida: ");
            int vP = int.Parse(Console.ReadLine());

            int multa = vP - vM;

            if (multa > 0 && multa <= 10)
            {
                Console.WriteLine("O valor da multa é de R$50,00.");
            }else if (multa > 11 && multa <= 30)
            {
                Console.WriteLine("O valor da multa é de R$100,00.");
            }else if(multa > 31)
            {
                Console.WriteLine("O valor da multa é de R$200,00.");
            }
           
            /*---------------------------------- QUESTÃO 13 ---------------------------------------*/
           
            Console.WriteLine("Informe a quantidade de Latão: ");
            double latao = double.Parse(Console.ReadLine());
            double zinco = latao * 30 / 100;
            double cobre = latao * 70 / 100;
            Console.WriteLine("Quantidade de Latão: " + latao);
            Console.WriteLine("Quantidade de Zinco: " + zinco);
            Console.WriteLine("Quantidade de cobre: " + cobre); 
            
            /*----------------------- QUESTÃO 14 ----------------------------*/
          
            Console.Write("Informe um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe outro número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());
            if (n2 != 0)
            {
                int quociente = n1 / n2;
                Console.WriteLine("O quociente de n1 por n2 é igual a " + quociente);
            }
            else
            {
                Console.WriteLine("DIVISÃO POR ZERO");
            }
          
            /*------------------------ QUESTÃO 15 ----------------------------*/
           
            Console.WriteLine("Informe o valor de A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor de B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor de C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a > b && a > c)
            {
                Console.WriteLine("Maior valor: A");
            }
            else if(b > a && b > c)
            {
                Console.WriteLine("Maior valor: B");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Maior valor: C");
            }
            

            /*-------------------------- QUESTÃO 16 ---------------------------*/
           
            Console.Write("Informe o 1° valor: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o 2° valor: ");
            int v2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o 3° valor: ");
            int v3 = int.Parse(Console.ReadLine());
            int maior;
            int meio;
            int menor;

            if ((v1 > v2) && (v1 > v3))
            {
           
                maior = v1;
                if (v2 > v3)
                {
                    meio = v2;
                    menor = v3;
                }
                else
                {
                    meio = v3;
                    menor = v2;
                }
                Console.WriteLine($"{menor}, {meio}, {maior}");
            }
            if ((v2 > v1) && (v2 > v3))
            {

                maior = v2;
                if (v1 > v3)
                {
                    meio = v1;
                    menor = v3;
                }
                else
                {
                    meio = v3;
                    menor = v1;
                }
                Console.WriteLine($"{menor}, {meio}, {maior}");
            }
            if ((v3 > v1) && (v3 > v2))
            {

                maior = v3;
                if (v2 > v1)
                {
                    meio = v2;
                    menor = v1;
                }
                else
                {
                    meio = v1;
                    menor = v2;
                }
                Console.WriteLine($"{menor}, {meio}, {maior}");
            }
           
            /*-------------------------- QUESTÃO 17 -------------------------*/
          
            Console.WriteLine("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Delta: " + delta);
            Console.WriteLine("Raíz x1: " + x1);
            Console.WriteLine("Raíz x1: " + x2);
           




            /*---------------------------- QUESTÃO 18 ------------------------------*/
           
            Console.Write("Informe o 1° valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o 2° valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o 3° valor: ");
            double v3 = double.Parse(Console.ReadLine());
            bool t;


            if ((v1 < v2 + v3) || (v2 < v1 + v3) || (v3 < v1 + v2))
            {
               t = true;
                Console.WriteLine("Com esses valores é possível formar um triângulo.");
            }
            else
            {
                t = false;
                Console.WriteLine("Com esses valores não é possível formar um triângulo.");
            }
            if (t == true)
            {
                if ((v1 == v2) && (v1 == v3) && (v2 == v3))
                {
                    Console.WriteLine("Triângulo Equilátero.");
                } else if ((v1 == v2) || (v1 == v3) || (v2 == v3))
                {
                    Console.WriteLine("Triângulo Isósceles.");
                }
                else if (((v1 != v2) || (v1 != v3) || (v2 != v3)))
                {
                    Console.WriteLine("Triângulo Escaleno.");
                }
                else
                {
                    Console.WriteLine("Não é possível formar um triângulo.");
                }
            }
            else
            {
                Console.WriteLine("Não é possível formar um triângulo.");
            }
          

            /*---------------------------- QUESTÃO 19 --------------------------*/
           
            int soma = 0;
            int n;
            
            for (int i = 0; i < 4; i++ )
            {
                
                Console.Write("Digite um número inteiro: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    soma = soma += n;
                }
                
            }
            Console.WriteLine("A soma dos números pares é igual a: " + soma);
           
            /*-----------------------------  QUESTÃO 20 ---------------------------------*/
           
            Console.Write("Informe o ano: ");
            int ano = int.Parse(Console.ReadLine());
            if ((ano % 400 == 0) || ((ano % 4 == 0) && (ano % 100 != 0)))
            {
                Console.WriteLine("Ano bissexto.");
            }
            else
            {
                Console.WriteLine("O ano não é bissexto.");
            }
           
        }
    }
}
