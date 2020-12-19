using System;
using System.Globalization;

namespace Lista_2_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista 2 de exercícios
            /*
            1) Escreva um programa para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela
            possui.Considere sempre anos completos, e que um ano possui 365 dias.Ex: uma pessoa com 19 anos
            possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
            */
            Console.WriteLine("Programa que conta quantos dias de vida você viveu");
            Console.WriteLine("Digite seu nome: ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade1 = int.Parse(Console.ReadLine());

            int dias1 = idade1 * 365;

            Console.WriteLine($"{nome1}, VOCÊ JÁ VIVEU {dias1} DIAS! ");

            /*
            2) Escreva um programa para ler o número total de eleitores de um município, o número de votos
            brancos, nulos e válidos.Calcular e escrever o percentual que cada um representa em relação ao total
            de eleitores.*/

            Console.WriteLine("Programa que faz a analise de votos eleitorais");
            Console.WriteLine("Digite o numero total de eleitores: ");
            int eleitores = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de votos brancos: ");
            int brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de votos nulos: ");
            int nulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de votos válidos: ");
            int validos = int.Parse(Console.ReadLine());

            double porcao_brancos = (brancos / eleitores) * 100;
            double porcao_nulos = (nulos / eleitores) * 100;
            double porcao_validos = (validos / eleitores) * 100;

            Console.WriteLine("Resultado da apuração: ");
            Console.WriteLine(porcao_brancos + "% de votos em branco ");
            Console.WriteLine(porcao_nulos + "% de votos nulos");
            Console.WriteLine(porcao_validos + "% de votos em branco ");

            /* 3) Escreva um programa para ler o salário mensal atual de um funcionário e o percentual de reajuste.
            Calcular e escrever o valor do novo salário. */

            Console.WriteLine("Programa que reajusta o valor de um salário");
            Console.WriteLine("Digite o valor do salário: ");
            double salario3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor percentual do aumento: ");
            double aumento3 = double.Parse(Console.ReadLine());

            double final3 = salario3 * (1 + (aumento3 / 100));
            Console.WriteLine("Salário final: " + final3);

            /*  4) O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do
                distribuidor e dos impostos(aplicados ao custo de fábrica).Supondo que o percentual do distribuidor
                seja de 28 % e os impostos de 45 %, escrever um programa para ler o custo de fábrica de um carro,
                calcular e escrever o custo final ao consumidor. */
            Console.WriteLine("Programa que reajusta o valor de um carro");
            Console.WriteLine("Digite o valor do custo de fabrica de um carro: ");
            double preco4 = double.Parse(Console.ReadLine());
            double final4 = preco4 + (preco4 * 0.28) + (preco4 * 0.28);
            Console.WriteLine("Somado aos impostos o valor final do custo de fabrica é de R$ " + final4);

            /*  5) Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês,
                uma comissão também fixa para cada carro vendido e mais 5 % do valor das vendas por ele
                efetuadas.Escrever um programa que leia o número de carros por ele vendidos, o valor total de suas
                vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do
                vendedor. */

            Console.WriteLine("Programa que calcula o valor final de um salario");
            Console.WriteLine("Digite o valor do numero de carros vendidos: ");
            int carros5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor total das vendas: ");
            double valorvenda5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do salario fisico: ");
            double salario5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da comissão: ");
            double comissao5 = double.Parse(Console.ReadLine());

            double novosalario5 = salario5 + (valorvenda5 * 0.05) + (comissao5 * carros5);
            Console.WriteLine("O salário final deste funcionário será de R$ " + novosalario5);

            /*  6) Faça um programa que receba um valor que foi depositado e exiba o valor com rendimento após um
                mês.Considere fixo o juro da poupança em 2 % a.m. */

            Console.WriteLine("Programa que calcula o rendimento de um deposito");
            Console.WriteLine("Digite o valor do deposito: ");
            double deposito6 = int.Parse(Console.ReadLine());

            double final6 = deposito6 * (1.02);

            Console.WriteLine("Após um mês, o deposito terá rendido e valerá R$ " + final6);

            /*  7) A Loja Mamão com Açúcar está vendendo seus produtos em 5(cinco) prestações sem juros.Faça
                um programa que receba um valor de uma compra e mostre o valor das prestações. */

            Console.WriteLine("Programa que calcula o valor de uma prestação ");
            Console.WriteLine("Digite o valor do produto: ");
            double valor7 = double.Parse(Console.ReadLine());

            double prestacao7 = valor7 / 5;

            Console.WriteLine("Cada uma das 5 prestações será de R$ " + prestacao7);


            /*  8) Faça um algoritmo que receba o preço de custo de um produto e mostre o valor de venda. Sabe - se
                que o preço de custo receberá um acréscimo de acordo com um percentual informado pelo usuário.*/
            Console.WriteLine("Programa que o valor final de uma venda");
            Console.WriteLine("Digite o valor inicial: ");
            double valor8 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de acrescimo: ");
            double acrescimo8 = double.Parse(Console.ReadLine());

            double final8 = valor8 + (valor8 * (acrescimo8 / 100));

            Console.WriteLine("O valor final de venda é de R$ " + final8);

            /*  9) A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada
                dia.Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50.Ao final do dia, o dono quer saber quanto
                arrecadou com a venda dos pães e broas(juntos), e quanto deve guardar numa conta de poupança(10 %
                do total arrecadado). Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos,
                faça um programa para ler as quantidades de pães e de broas, e depois calcular os dados solicitados. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");

            Console.WriteLine("Programa que calcula o valor final de vendas");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o numero de paozinhos vendidos: ");
            int pao9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de broas vendidos: ");
            int broa9 = int.Parse(Console.ReadLine());

            double receita9 = 1.50 * broa9 + 0.12 * pao9;

            Console.WriteLine("Resultados: ");
            Console.WriteLine("Receita total: R$ " + receita9);
            Console.WriteLine("Valor a ir para a poupança: R$ " + (receita9 * 0.10));

            /* 10) Um motorista deseja colocar no seu tanque X reais de gasolina.Escreva um programa para ler o
               preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu colocar no
               tanque. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Programa que calcula o numero de litros de gasolina");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o preço por litro de gasolina: ");
            double preco10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do pagamento: ");
            double pagamento10 = double.Parse(Console.ReadLine());

            double litros10 = pagamento10 / preco10;

            Console.WriteLine("A quantidade, em litros, de gasolina pelo valor de pagamento é de " + litros10 + " L");

            /*  11) O restaurante a quilo Bem - Bão cobra R$12,00 por cada quilo de refeição.Escreva um programa
                que leia o peso do prato montado pelo cliente(em quilos) e imprima o valor a pagar. */
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");

            Console.WriteLine("Programa que calcula o valor por uma refeição");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o peso do prato, em Kg: ");
            double peso11 = double.Parse(Console.ReadLine());

            double custo11 = 12.00 * peso11;

            Console.WriteLine("O total a ser pago é R$ " + custo11);

            /*  12) Faça um programa que receba dois números, calcule e mostre a divisão do primeiro número pelo
                segundo.Sabe - se que o segundo número não pode ser zero. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");

            Console.WriteLine("Programa que mostra a divisão entre dois numeros");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o valor do primeiro numero: ");
            double num01 = double.Parse(Console.ReadLine());
            double num02 = 0;
            while (num02 == 0)
            {
                Console.WriteLine("Digite o valor do segundo numero (divisor): ");
                Console.WriteLine("O valor precisa ser MAIOR que 0 (zero)");

                num02 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O resultado da divisão é " + (num01 / num02));


            /* 13) Faça um programa que receba o peso de uma pessoa em quilos, calcule e mostre esse peso em
               gramas. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Programa que converte quilos para gramas ");
            Console.WriteLine("Digite o valor em quilos: ");
            double quilo13 = double.Parse(Console.ReadLine());
            Console.WriteLine("Esse valor corresponde a " + (quilo13 * 100) + " gramas");

            /* 14) Faça um programa que receba um número e diga se este número está no intervalo entre 100 e 200. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Programa que aponta se um numero está entre 1 a 100 ");
            Console.WriteLine("Digite o valor: ");
            double valor14 = double.Parse(Console.ReadLine());

            if (valor14 > 100 && valor14 < 200)
            {
                Console.WriteLine("O valor está dentro do intervalo: ");
            }
            else
            {
                Console.WriteLine("O valor está fora do intervalo: ");
            }

            /* 15)  Escrever um programa que leia o nome e as três notas obtidas por um aluno durante o semestre.
                    Calcular a sua média(aritmética), informar o nome e sua menção aprovado(media >= 7), Reprovado
                    (media <= 5) e Recuperação(media entre 5.1 a 6.9). */

            double nota15 = 0;
            double soma15 = 0;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Programa aponta se um aluno foi reprovado ou não ");
            for (int i = 0; i > 3; i++)

            {
                Console.WriteLine($"Digite o valor da {i + 1}ª nota: ");
                nota15 = double.Parse(Console.ReadLine());
                soma15 += nota15;
            }

            double media15 = soma15 / 3;

            if (media15 <= 5)
            {
                Console.WriteLine("Aluno REPROVADO");
            }
            if (media15 > 5 && media15 <= 7)
            {
                Console.WriteLine("Aluno EM RECUPERAÇÃO ");
            }
            if (media15 > 7)
            {
                Console.WriteLine("Aluno APROVADO ");
            }

            /*  16) Faça um programa que receba a idade de uma pessoa e mostre mensagem informando “maior de
                idade”, “menor de idade” ou "idoso(a)".Considere a idade a partir de 18 anos como maior de idade. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Programa que aponta qual sua faixa etária ");
            Console.WriteLine("Digite sua idade");
            int idade16 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você é: ");
            if (idade16 < 18)
            {
                Console.Write("MENOR DE IDADE");
            }
            if (idade16 >= 18 && idade16 <= 60)
            {
                Console.Write("MAIOR DE IDADE");
            }
            if (idade16 > 60)
            {
                Console.WriteLine("IDOSO");
            }

            /* 17) Escrever um programa que leia o nome e o sexo de uma pessoa e informe o nome e se ela é
                homem ou mulher. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Programa que aponta seu gênero baseado no seu sexo ");
            Console.WriteLine("Se seu genero é feminino, digite 1, se masculino, digite 02");
            int genero17 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você é: ");
            if (genero17 == 1)
            {
                Console.Write("MULHER");
            }
            if (genero17 == 2)
            {
                Console.Write("HOMEM");
            }

            /*  18) A concessionária de veículos “CARANGO” está vendendo os seus veículos com desconto.Faça
                um algoritmo que calcule e exiba o valor do desconto e o valor a ser pago pelo cliente. O desconto
                deverá ser calculado sobre o valor do veículo de acordo com o combustível(álcool – 25 %, gasolina –
                21 % ou diesel –14 %).Com valor do veículo zero encerra entrada de dados.Informe total de desconto
                total pago pelos clientes. */
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Sistema de veiculos Carango ");
            bool loop18 = true;
            while (loop18 == true)
            {
                Console.WriteLine("Calculo de desconto de carros ");

                Console.WriteLine("Qual o combustivel do carro?");
                Console.WriteLine("1 - Alcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - DIesel");
                Console.WriteLine("0 - Sair");
                int selecao18 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o valor do veiculo");
                double q18_preco = double.Parse(Console.ReadLine());

                if (selecao18 == 1)
                {
                    Console.WriteLine("Com o desconto de 25%, o preço final é de R$ " + (q18_preco * 0.75));
                }
                if (selecao18 == 2)
                {
                    Console.WriteLine("Com o desconto de 21%, o preço final é de R$ " + (q18_preco * 0.79));
                }
                if (selecao18 == 3)
                {
                    Console.WriteLine("Com o desconto de 14%, o preço final é de R$ " + (q18_preco * 0.86));
                }
                if (selecao18 == 0)
                {
                    loop18 = false;
                }
            }

            /* 19) Escrever um programa que leia três valores inteiros distintos e os escreva em ordem crescente. */

            /* 20) A escola “APRENDER” faz o pagamento de seus professores por hora/ aula.Faça um programa
                que calcule e exiba o salário de um professor.O valor da hora/ aula segue abaixo:
                - Professor Nível 1 R$12,00 por hora/ aula 
                - Professor Nível 2 R$17,00 por hora/ aula
                - Professor Nível 3 R$25,00 por hora/ aula */
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Sistema de calculo de salario da Escola Aprender");
            bool loop20 = true;
            while (loop20 == true)
            {
                Console.WriteLine("Calculo de salário ");

                Console.WriteLine("Qual o nível do professor");
                Console.WriteLine("1 - Nivel 1");
                Console.WriteLine("2 - Nivel 2");
                Console.WriteLine("3 - Nivel 3");
                Console.WriteLine("0 - Sais");

                int selecao20 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero de horas trabalhadas");
                double preco20 = double.Parse(Console.ReadLine());

                if (selecao20 == 1)
                {
                    Console.WriteLine("O salário deste professor será de: R$ " + (preco20 * 12.00));
                }
                if (selecao20 == 2)
                {
                    Console.WriteLine("Com o desconto de 21%, o preço final é de R$ " + (preco20 * 17.00));
                }
                if (selecao20 == 3)
                {
                    Console.WriteLine("Com o desconto de 14%, o preço final é de R$ " + (preco20 * 25.00));
                }
                if (selecao20 == 0)
                {
                    loop20 = false;
                }
            }

            /* 21) Elabore um programa que, dada a idade de um nadador.Classifique - o em uma das seguintes
                    categorias: Infantil A = 5 - 7 anos, Infantil B = 8 - 10 anos, juvenil A = 11 - 13 anos juvenil B = 14 - 17
                    anos e Sênior = 18 - 25 anos.Apresentar mensagem “idade fora da faixa etária” quando for outro ano
                    não contemplado. */
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Sistema de classificação etária");
            Console.WriteLine("Digite sua idade");
            int idade21 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sua classificação é : ");


            if (idade21 > 5 && idade21 < 7)
            {
                Console.WriteLine("genero infantil");
            }
            if (idade21 > 7 && idade21 < 10)
            {
                Console.WriteLine("genero juvenil A");
            }
            if (idade21 > 10 && idade21 < 13)
            {
                Console.WriteLine("genero infantil");
            }
            if (idade21 > 14 || idade21 < 5)
            {
                Console.WriteLine(" idade fora da fauxa etária");
            }

            /*  22) Faça um programa que mostre a tabuada do número 5.Utiliza estrutura de repetição. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Sistema que reproduz a tabuada do numero 5");
            Console.WriteLine(" ");
            for (int i = 1; i > 10; i++)
            {
                Console.WriteLine($"5 * {i} = " + (5 * i));

            }

            /* 23) Uma loja tem 15 clientes cadastrados e deseja enviar uma correspondência a cada um deles
                anunciando um bônus especial.Faça um programa que leia o nome do cliente e o valor de suas
                compras no ano passado.Calcule e mostre um bônus de 10 % se o valor das compras for menor de R$
                1.000, 00 e de 15 %, caso contrário. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Sistema que envia correspondencia aos clientes");
            Console.WriteLine(" ");
            string[] nome23 = new string[10];
            double[] compra23 = new double[10];
            double[] bonus23 = new double[10];

            for (int i = 1; i > 10; i++)
            {
                Console.WriteLine("Insira o nome do cliente");
                nome23[i] = Console.ReadLine();
                Console.WriteLine("Insira o valor da compra");
                compra23[i] = double.Parse(Console.ReadLine());

                if (compra23[i] < 1000)
                {
                    bonus23[i] = compra23[i] * 0.10;
                }
                else if (compra23[i] > 1000)
                {
                    bonus23[i] = compra23[i] * 0.15;
                }

            }

            /*  24) Faça um programa que receba a idade de 50 pessoas e que calcule e mostre a quantidade de
                pessoas com idade maior ou igual a 18 anos. */

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("_________________");
            Console.WriteLine(" ");
            Console.WriteLine("Sistema que conta quantos são maiores de idade");
            Console.WriteLine(" ");
            int cont24 = 0;
            int idade24;

            for (int i = 1; i > 50; i++)
            {
                Console.WriteLine("Digite a idade dessa pessoa: ");
                idade24 = int.Parse(Console.ReadLine());

                if (idade24 <= 18)
                {
                    cont24 = cont24 + 1;
                }
            }
            Console.WriteLine("Hello World!");

            /*25) Faça um programa que receba a idade de 15 pessoas e que calcule e mostre:

                     A quantidade de pessoas em cada faixa etária.*/
            
            int[] idade = new int[15];

            /* contadores */
            int ate15 = 0;
            int entre16e30 = 0;
            int entre31e45 = 0;
            int entre46e60 = 0;
            int mais61 = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Informe a idade da " + i + "° pessoa: ");
                idade[i] = int.Parse(Console.ReadLine());
                if (idade[i] <= 15)
                {
                    ate15 += 1;

                }
                else if (idade[i] >= 16 && idade[i] <= 30)
                {
                    entre16e30 += 1;

                }
                else if (idade[i] >= 31 && idade[i] <= 45)
                {
                    entre31e45 += 1;

                }
                else if (idade[i] >= 46 && idade[i] <= 60)
                {
                    entre46e60 += 1;

                }
                else if (idade[i] >= 61)
                {
                    mais61 += 1;

                }
            }

            Console.WriteLine();
            Console.WriteLine("Quantidade de pessoas que tem até 15 anos: " + ate15);
            Console.WriteLine("Quantidade de pessoas que tem entre 16 e 30 anos: " + entre16e30);
            Console.WriteLine("Quantidade de pessoas que tem entre 31 e 45 anos: " + entre31e45);
            Console.WriteLine("Quantidade de pessoas que tem entre 46 e 60 anos: " + entre46e60);
            Console.WriteLine("Quantidade de pessoas que tem mais de 61 anos: " + mais61);


            /* 26) Uma loja utiliza o código V para transações a vista e P para transações a prazo. Faça um programa
                que receba o código e o valor de 15 transações. Calcule e mostre:

                 O valor total das compras a vista.
                 O valor total das compras a prazo.
                 O valor total das compras efetuadas. */
            double totalaVista = 0;
            double totalaPrazo = 0;
            double valorTotal = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Informe o Código da " + i + "° transação (V - à vista ou P - à prazo): ");
                string cod = Console.ReadLine();
                Console.Write("Informe o valor da " + i + "° transação: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (cod == "V" || cod == "v")
                {
                    totalaVista = totalaVista += valor;
                }
                else if (cod == "P" || cod == "p")
                {
                    totalaPrazo = totalaPrazo += valor;
                }
                valorTotal = valorTotal += valor;

            }
            Console.WriteLine();
            Console.WriteLine("Valor total das compras à vista: " + totalaVista.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total das compras à prazo: " + totalaPrazo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total das compras efetuadas: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            
            /* 27) Faça um programa que receba a idade, a altura e o peso de 25 pessoas. Calcule e mostre:

                 A quantidade de pessoas com mais de 90 quilos.
                 A média das idades das 25 pessoas. */

            double mais90 = 0;
            double idadeTotal = 0;
            double media = 0;

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine();
                Console.Write("Informe a idade da " + i + "° pessoa: ");
                int idade2 = int.Parse(Console.ReadLine());
                Console.Write("Informe a altura da " + i + "° pessoa: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Informe o peso da " + i + "° pessoa: ");
                double peso = double.Parse(Console.ReadLine());

                idadeTotal = idadeTotal += idade2;
                media = idadeTotal / 25;
                if (peso > 90)
                {
                    mais90 += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de pessoas que pesa mais de 90 quilos: " + mais90);
            Console.WriteLine("A media da idade total das 25 pessoas é igual a: " + media);

            /* 28) Faça um programa que receba a idade e o sexo de sete pessoas e que calcule e mostre:

                     A idade média do grupo.
                     A idade média das mulheres.
                     A idade média dos homens. */

            double idadeTotalGrupo = 0;
            double idadeTotalMulheres = 0;
            double idadeTotalHomens = 0;
            int contMulheres = 0;
            int contHomens = 0;

            double mediaGrupo = 0;
            double mediaHomens = 0;
            double mediaMulheres = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                Console.Write("Informe a idade da " + i + "° pessoa: ");
                int idade3 = int.Parse(Console.ReadLine());
                Console.Write("Informe o sexo da " + i + "° pessoa (F ou M): ");
                string sexo = Console.ReadLine();

                idadeTotalGrupo = idadeTotalGrupo + idade3;
                if (sexo == "F" || sexo == "f")
                {
                    idadeTotalMulheres = idadeTotalMulheres + idade3;
                    contMulheres += 1;
                }
                else if (sexo == "M" || sexo == "m")
                {
                    idadeTotalHomens = idadeTotalHomens + idade3;
                    contHomens += 1;
                }
                mediaGrupo = idadeTotalGrupo / 7;
                mediaMulheres = idadeTotalMulheres / contMulheres;
                mediaHomens = idadeTotalHomens / contHomens;
            }
            Console.WriteLine();
            Console.WriteLine("A idade média do grupo é: " + mediaGrupo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A idade média das mulheres é: " + mediaMulheres.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A idade média dos homens é: " + mediaHomens.ToString("F2", CultureInfo.InvariantCulture));

            /* 29) Faça um programa que receba dez idades, pesos e alturas e que calcule e mostre:
                    A média das idades das dez pessoas.
                    A quantidade de pessoas com peso superior a 90quilos e altura inferior a 1.50. */

            double totalIdade = 0;
            double mediaIdade = 0;
            int contmais90 = 0;
            int contaltura2 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.Write("Informe a idade da " + i + "° pessoa: ");
                int idade3 = int.Parse(Console.ReadLine());
                Console.Write("Informe o peso da " + i + "° pessoa: ");
                double peso2 = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura da " + i + "° pessoa: ");
                double altura2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                totalIdade = totalIdade + idade3;
                mediaIdade = totalIdade / 10;
                if (peso2 > 90)
                {
                    contmais90 += 1;
                }
                if (altura2 < 1.50)
                {
                    contaltura2 += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("A média da idade das 10 pessoas é: " + mediaIdade.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A quantidade de pessoas que pesam mais de 90 quilos é: " + contmais90);
            Console.WriteLine("A quantidade de pessoa com altura inferior a 1.50 é: " + contaltura2);

            /* 30) Faça um programa que receba várias idades e que calcule e mostre a média das idades digitadas.
                    Finalize digitando a idade igual a zero. */
            int contIdadesDigitadas = 0;
            int totalIdadesDigitadas = 0;
            double mediaIdadesDigitadas = 0;
            Console.Write("Informe uma idade: ");
            int idade4 = int.Parse(Console.ReadLine());
            while (idade4 != 0)
            {
                Console.Write("Informe uma idade: ");
                idade4 = int.Parse(Console.ReadLine());

                contIdadesDigitadas += 1;
                totalIdadesDigitadas = totalIdadesDigitadas + idade4;
                mediaIdadesDigitadas = totalIdadesDigitadas / contIdadesDigitadas;


            }
            Console.WriteLine();
            Console.WriteLine("A quantidade de idades digitadas é igual a: " + contIdadesDigitadas);
            Console.WriteLine("A média das idades digitadas é igual a: " + mediaIdadesDigitadas.ToString("F2", CultureInfo.InvariantCulture));

            /* 31) Faça um programa que receba a idade e o sexo de sete pessoas e que calcule e mostre:

                 A idade média do grupo.
                 A idade média das mulheres.
                 A idade média dos homens. */

            double idadeTotalGrupo2 = 0;
            double idadeTotalMulheres2 = 0;
            double idadeTotalHomens2 = 0;
            int contMulheres2 = 0;
            int contHomens2 = 0;

            double mediaGrupo2 = 0;
            double mediaHomens2 = 0;
            double mediaMulheres2 = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                Console.Write("Informe a idade da " + i + "° pessoa: ");
                int idade3 = int.Parse(Console.ReadLine());
                Console.Write("Informe o sexo da " + i + "° pessoa (F ou M): ");
                string sexo = Console.ReadLine();

                idadeTotalGrupo2 = idadeTotalGrupo2 + idade3;
                if (sexo == "F" || sexo == "f")
                {
                    idadeTotalMulheres2 = idadeTotalMulheres2 + idade3;
                    contMulheres2 += 1;
                }
                else if (sexo == "M" || sexo == "m")
                {
                    idadeTotalHomens2 = idadeTotalHomens2 + idade3;
                    contHomens2 += 1;
                }
                mediaGrupo2 = idadeTotalGrupo2 / 7;
                mediaMulheres2 = idadeTotalMulheres2 / contMulheres2;
                mediaHomens2 = idadeTotalHomens2 / contHomens2;
            }
            Console.WriteLine();
            Console.WriteLine("A idade média do grupo é: " + mediaGrupo2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A idade média das mulheres é: " + mediaMulheres2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A idade média dos homens é: " + mediaHomens2.ToString("F2", CultureInfo.InvariantCulture));

            /* 32) Faça um programa que mostre os números múltiplos de 5 no intervalo de 0 a 1000. */

            Console.WriteLine("Os múltiplos de 5 no intervalo de 0 a 1000 são: ");
            for (int i = 0; i <= 1000; i++)
            {

                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            /* 33) Faça uma função que calcule a média de 4 notas. */

            Console.WriteLine("Informe a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a quarta nota: ");
            double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaNotas = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média das notas é igual a: " + mediaNotas);

            /* 34) Faça uma função que receba o valor do saque e o saldo da conta e que calcule e mostre o novo
                saldo. */

            Console.Write("Informe o saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            saldo = saldo - saque;
            Console.WriteLine("O novo saldo da conta é: " + saldo.ToString("F2", CultureInfo.InvariantCulture));

            /* 35) Faça um programa que receba o valor do salário e o percentual de reajuste calcule e mostre o novo
                salário com o reajuste. */

            Console.Write("Informe o valor do salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o percentual de reajuste: ");
            double reajuste = double.Parse(Console.ReadLine());
            salario = salario + (reajuste * salario) / 100;
            Console.WriteLine("O valor do salário com o reajuste é de: " + salario.ToString("F2", CultureInfo.InvariantCulture));

            /* 36) Faça um programa que receba o valor do salário e o percentual de reajuste calcule e mostre o novo
                salário com o reajuste. */

            Console.Write("Informe o valor do salário: ");
            double salario36 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o percentual de reajuste: ");
            double reajuste36 = double.Parse(Console.ReadLine());
            salario36 = salario36 + (reajuste36 * salario36) / 100;
            Console.WriteLine("O valor do salário com o reajuste é de: " + salario36.ToString("F2", CultureInfo.InvariantCulture));

            /*37) Existe 2 tipos de estrutura de repetição, cite e explique a diferença entre cada uma delas (dê
                exemplos). 
            
            Estrutura while: usado quando não sabemos ao certo quantas repetições serão feitas. 
Exemplo:
            While(resposta != 0){
                Console.WriteLine("Digite uma pergunta: ");
                string pergunta = Console.WriteLine();

                Console.WriteLine("Deseja digitar outra pergunta? Digite 1 para sim ou 0 para não: ")
            int resposta = int.Parse(Console.ReadLine());
            }
            Estrutura for: usado quanto já sabemos quantas repetições serão feitas.
            Exemplo:
for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Digite uma pergunta: ");
                    string pergunta = Console.ReadLine();
                }
            */


            /* 38) Para que se utiliza uma função, qual sua importância?
              
              As funções são usadas para realizar tarefas como calcular a soma de dois números e etc. Elas são importantes pois elas é que dizem o que o objeto vai fazer,
             facilitando assim a programação;

            */

            /* 39) O que são estruturas de condição, cite e exemplifique as estruturas de condição utilizadas em sala.
              
            Estruturas de condição, são estruturas que realizam diferentes tarefas de acordo com a condição.
Exemplo de estrutura de condição simples: 
if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            Exemplo de estrutura de condição composta:
if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else
            {
                Console.WriteLine("Boa tarde!");
            }
            Exemplo de estrutura de condição de encadeamentos:
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hora > 18)
            {
                Console.WriteLine("Boa noite!");
            }
            */


            /* 41) O que são classes e objetos? Exemplifique.
              
            Classe é a onde é feita a descrição dos atributos e comportamentos de um objeto.Objeto é a representação
 de algo real, que tem atributos e comportamento.
Exemplo de classe:
class Pessoa
        {
            public string Nome;
        }

        Exemplo de Objeto:
Pessoa p = new Pessoa();
            */

            /* 42) O que são comandos de entrada e saída? Quais os comandos utilizados em Java?
              
            Comandos de entrada são utilizados para receber os dados.E comandos de saída são usados para exibir os dados.
           Exemplo de Comando de entrada em c#: Console.ReadLine();
    Exemplo de Comando de Saída em c# Console.WriteLine;
            */
        }
    }
}
