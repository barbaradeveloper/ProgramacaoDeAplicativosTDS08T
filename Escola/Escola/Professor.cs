using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    class Professor
    {
        public string Nome;
        public string Sobrenome;
        public int Telefone;
        public bool Oculos;

        public Professor()
        {
            Oculos = true;
        }

        public Professor(string nome, string sobrenome, int telefone) : this()
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;

        }
        public Professor(string nome, string sobrenome, int telefone, bool oculos): this (nome, sobrenome, telefone)
        {
            Oculos = oculos;
        }
    }
}
