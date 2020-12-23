using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_2_Parte_2
{
    class Rica: Pessoa
    {
        public double DINHEIRO { get; set; }

        public Rica(string nome, int idade, double dinheiro) : base(nome, idade)
        {
            DINHEIRO = dinheiro;
        }

        public void FazCompras(double valor)
        {
            if (valor <= DINHEIRO)
            {
                DINHEIRO -= valor;
            }
        }
    }
}
