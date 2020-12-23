using System;
using System.Collections.Generic;
using System.Text;

namespace Lista4_Ativ_1
{
    class Administrativo: Assistente
    {
        public bool Turno { get; set; }
        public double Adicional { get; set; }
        public double  Salario { get; set; }

        public Administrativo(int matricula, bool turno, double adicional, double salario): base(matricula)
        {
            Matricula = matricula;
            Turno = turno;
            if (turno == true)
            {
                Adicional = adicional;
            }
            else
            {
                Adicional = 0;
            }

            Salario = salario + adicional;
        }

    }
}
