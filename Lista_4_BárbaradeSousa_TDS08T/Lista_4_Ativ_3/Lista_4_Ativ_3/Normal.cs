using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_3
{
    class Normal:Ingressos
    {
        public Normal(double valor, int id) : base(valor, id)
        {
            Valor = valor;
            Id = id;

        }

        public override string ToString()
        {
            return Valor.ToString("Valor: " + Valor);
        }
    }
}
