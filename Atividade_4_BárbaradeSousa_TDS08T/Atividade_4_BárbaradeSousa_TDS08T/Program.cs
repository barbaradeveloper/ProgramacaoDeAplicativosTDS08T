using System;

namespace Atividade_4_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ATIVIDADE 4 - ENTRADA E SAÍDA DE DADOS */

            /* Questão 1 
              Faça um programa que exiba na tela os seguintes dados da sua família.
                a) Nome
                b) grau de parentesco
                c) idade 
                d) gênero
                c) livro proferido 
            */
            string nome1 = "Isnete";
            string nome2 = "José";
           

            string grauParentesco1 = "Mãe";
            string grauParentesco2 = "Pai";

            int idade1 = 55;
            int idade2 = 60;

            char genero1 = 'F';
            char genero2 = 'M';


            string livroP1 = "Ágape";
            string livroP2 = "Percy Jackson e o ladrão de raios ";

            Console.WriteLine("---------------QUESTÃO 1----------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + nome1 + " |  Grau de Parentesco: " + grauParentesco1 + " | Idade: " + idade1 +
                " | Genêro: " + genero1 + " | Livro Preferido: " + livroP1);
            Console.WriteLine("Nome: " + nome2 + " |  Grau de Parentesco: " + grauParentesco2 + " | Idade: " + idade2 +
               " | Genêro: " + genero2 + " | Livro Preferido: " + livroP2);

            Console.WriteLine();

            /* Questão 2 
              Faça um programa que imprima na tela os seguintes dados sobre você
                a) Nome
                b) idade
                c) salario pretendido 
                d) data de nascimento 
                e) filme preferido 
            */

            string nome3 = "Bárbara";
            int idade3 = 19;
            float salarioPretendido = 5000f;
            string filmePreferido = "Vingadores Ultimato";

            Console.WriteLine("---------------QUESTÃO 2----------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + nome3 + " | Idade: " + idade3 + " | Salário Pretendido " + salarioPretendido  + " | Filme Preferido: " + filmePreferido);
            Console.WriteLine();
            /* Questão 3 
              Faça um programa que imprima na tela as informações  abaixo sobre três livros.
                a) nome do livro 
                b) autor
                c) editora
                d) quantidade de páginas
                e) ano de lançamento 
             
             */

            string nomeL1 = "A última música";
            string nomeL2 = "O lar da senhorita Pelegrine para crianças peculiares";
            string nomeL3 = "Ponto de Impacto";

            string autorL1 = "Nicholas Sparks";
            string autorL2 = "Ransom Riggs";
            string autorL3 = "Dan Brown";

            string editoraL1 = "Grand Central Publishing";
            string editoraL2 = "Quirk Books";
            string editoraL3 = "Pocket Books";

            int qtdL1 =  350;
            int qtdL2 = 459;
            int qtdL3 = 430;


            int anoL1 = 2009;
            int anoL2 = 2011;
            int anoL3 = 2001;

            Console.WriteLine("---------------QUESTÃO 3----------------------");
            Console.WriteLine();
            Console.WriteLine("Nome do Livro: " + nomeL1 + " | Autor: " + autorL1 + " | Editora: " + editoraL1 + " | Quantidade de Páginas " + qtdL1 +
                " | Ano de Lançamento: " + anoL1);
            Console.WriteLine("Nome do Livro: " + nomeL2 + " | Autor: " + autorL2 + " | Editora: " + editoraL2 + " | Quantidade de Páginas " + qtdL2 +
               " | Ano de Lançamento: " + anoL2);
            Console.WriteLine("Nome do Livro: " + nomeL3 + " | Autor: " + autorL3 + " | Editora: " + editoraL3 + " | Quantidade de Páginas " + qtdL3 +
               " | Ano de Lançamento: " + anoL3);
            Console.WriteLine();


            /* Questão 4 
             Faça um programa que imprima na tela as informações abaixo sobre três filmes.
                a) nome do filme
                b) diretor 
                c) ano de lançamento 
                d) valor do orçamento 
                e) gênero do filme 
                f) protagonista 
             
             */

            string nomeF1 = "Fragmentado";
            string nomeF2 = "Mib Homens de Preto";
            string nomeF3 = "O terno de dois bilhões de dólares";

            string diretorF1 = "M. Night Shyamalan";
            string diretorF2 =  "Barry Sonnenfeld";
            string diretorF3 = "Kevin Donavan";

            int anoF1 = 2017;
            int anoF2 = 1997;
            int anoF3 = 2002;

            float valorF1 = 1000000000f;
            float valorF2 = 2000000000f;
            float valorF3 = 3000000000f;

            string generoF1 =  "Terror";
            string generoF2 = "Ficcção Ciêntífica";
            string generoF3 = "Ação/Comédia";

            string protagonistaF1 = "James Mc Avoy";
            string protagonistaF2 = "Will Smith";
            string protagonistaF3 = "Jackie Chan";

            Console.WriteLine("---------------QUESTÃO 4----------------------");
            Console.WriteLine();
            Console.WriteLine("Nome do Filme: " + nomeF1 + " | Diretor: " + diretorF1 + " | Ano de Lançamento: " + anoF1 + " | Valor do Orçamento: " + valorF1 +
                " | Gênero do Filme: " + generoF1 + " | Protagonista: " + protagonistaF1);
            Console.WriteLine("Nome do Filme: " + nomeF2 + " | Diretor: " + diretorF2 + " | Ano de Lançamento: " + anoF2 + " | Valor do Orçamento: " + valorF2 +
                " | Gênero do Filme: " + generoF2 + " | Protagonista: " + protagonistaF2);
            Console.WriteLine("Nome do Filme: " + nomeF3 + " | Diretor: " + diretorF3 + " | Ano de Lançamento: " + anoF3 + " | Valor do Orçamento: " + valorF3 +
                " | Gênero do Filme: " + generoF3 + " | Protagonista: " + protagonistaF3);
        }
    }
}
