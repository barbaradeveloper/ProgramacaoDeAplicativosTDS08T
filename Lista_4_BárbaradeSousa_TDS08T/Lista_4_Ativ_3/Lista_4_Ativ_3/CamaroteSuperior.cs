using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_3
{
    class CamaroteSuperior: Vip
    {
        public int Cadeira;

        public CamaroteSuperior()
        {

        }

        public CamaroteSuperior(double valor, int id, double adicional, int cadeira) : base(valor, id, adicional)
        {
            Valor = valor + adicional + 40;
            Id = id;
            Cadeira = cadeira;

        }


        public override string ToString()
        {
            return Cadeira.ToString();

        }
    }
}
