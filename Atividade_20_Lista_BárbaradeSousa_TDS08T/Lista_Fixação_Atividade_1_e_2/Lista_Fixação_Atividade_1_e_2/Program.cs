using System;
using System.Collections.Generic;


namespace Lista_Fixação_Atividade_1_e_2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Atividade 1: Criar uma lista com 10 livros
           List<string> livros = new List<string> { "Harry Potter", "A Cabana", "Ponto de Impacto", "A Última Música",
               "O Jardim das Borboletas", "Fallen", "A menina que roubava livros", "A Biblioteca Invisível", 
               "O Feitiçeiro da montanha de fogo", "A estrada da noite"};

            foreach (string nomes in livros)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("--------------------------------------");

            // Atividade 2: Utilizar os métodos estudados
            // Add
            livros.Add("O Lar da senhorita Peregrine para crianças peculiares");
            foreach (string nomes in livros)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("-------------------------------------------");

            // Insert
            livros.Insert(2, "O pequeno Príncipe");
            foreach (string nomes in livros)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("-------------------------------------------");

            // Count
            Console.WriteLine(livros.Count);
            Console.WriteLine("-------------------------------------------");

            // Find
            string p = livros.Find(x => x[0] == 'P');
            Console.WriteLine(p);
            Console.WriteLine("-------------------------------------------");

            // FindLast
            string a = livros.FindLast(x => x[0] == 'A');
            Console.WriteLine(a);
            Console.WriteLine("-------------------------------------------");

            // FindLastIndex
            int posicao = livros.FindLastIndex(x => x[0] == 'F');
            Console.WriteLine(posicao);          
            Console.WriteLine("-------------------------------------------");

            // FindAll
            List<string> livros2 = livros.FindAll(x => x.Length == 6);
            foreach (string nomes in livros2)
            {
                Console.WriteLine(nomes);
            }
            // Remove
            livros.Remove("A Biblioteca Invisível");
            foreach (string nomes in livros)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("-------------------------------------------");

            // RemoveAll
            livros.RemoveAll(x => x[0] == 'A');
            foreach (string nomes in livros)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("-------------------------------------------");

            // RemoveAt
            livros.RemoveAt(0);
            foreach (string nomes in livros)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("-------------------------------------------");

            // RemoveRange
            livros.RemoveRange(1, 2);
            foreach (string nomes in livros)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
