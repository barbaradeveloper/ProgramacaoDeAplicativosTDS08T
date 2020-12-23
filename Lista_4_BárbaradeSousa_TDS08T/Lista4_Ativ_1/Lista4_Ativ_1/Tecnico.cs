using System;
using System.Collections.Generic;
using System.Text;

namespace Lista4_Ativ_1
{
    class Tecnico: Assistente
    {
        public double Adicional { get; set; }
        public double Salario { get; set; }


        public Tecnico(int matricula, double salario, double adicional) : base(matricula)
        {
            Matricula = matricula;
            Adicional = adicional;
            Salario = salario + adicional;

        }
    }
}
