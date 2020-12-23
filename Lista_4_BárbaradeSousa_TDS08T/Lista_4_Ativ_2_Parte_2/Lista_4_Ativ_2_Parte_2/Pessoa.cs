using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_2_Parte_2
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
