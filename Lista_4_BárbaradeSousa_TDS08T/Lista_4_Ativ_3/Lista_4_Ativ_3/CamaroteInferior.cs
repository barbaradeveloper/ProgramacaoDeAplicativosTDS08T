using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_3
{
    class CamaroteInferior: Vip
    {
        public int Cadeira;

        public CamaroteInferior()
        {

        }

        public CamaroteInferior(double valor, int id, double adicional, int cadeira) : base(valor, id, adicional)
        {
            Valor = valor + adicional;
            Id = id;
            Cadeira = cadeira;

        }

        public override string ToString()
        {
            return Cadeira.ToString();

        }
    }
}
