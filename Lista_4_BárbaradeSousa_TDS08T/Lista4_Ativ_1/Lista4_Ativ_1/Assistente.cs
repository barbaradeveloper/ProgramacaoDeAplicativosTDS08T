using System;
using System.Collections.Generic;
using System.Text;

namespace Lista4_Ativ_1
{
    class Assistente: Funcionario
    {
        public int Matricula { get; set; }

        public Assistente(int matricula) : base()
        {
            Matricula = matricula;
        }

        public override string ToString()
        {
            return Matricula.ToString();
        }
    }
}
