using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_3
{
    class Vip: Ingressos
    {
        public Vip()
        {

        }

        public Vip(double valor, int id, double adicional) : base(valor, id)
        {
            Valor = valor + adicional;
            Id = id;

        }
    }
}
