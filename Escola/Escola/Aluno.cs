using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    class Aluno
    {
        public string Nome;
        public string Email;
        public string Cidade;
        public bool Status;


        public Aluno()
        {
            Status = true;
        }
        public Aluno(string nome, string email, string cidade) : this()
        {
            Nome = nome;
            Email = email;
            Cidade = cidade;
        }
        public Aluno(string nome, string email, string cidade, bool status) : this(nome, email, cidade)
        {
            Status = status;
        }
    }
}
