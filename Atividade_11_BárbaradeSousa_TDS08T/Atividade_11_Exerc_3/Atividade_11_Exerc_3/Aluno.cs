using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_11_Exerc_3
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double Soma()
        {
            double NotaFinal = N1 + N2 + N3;
            return NotaFinal;
        }
    }
}
