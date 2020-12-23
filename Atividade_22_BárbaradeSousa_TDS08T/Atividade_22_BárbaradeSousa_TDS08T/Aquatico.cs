using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_22_BárbaradeSousa_TDS08T
{
    class Aquatico: Veiculo
    {
        
        public string Cor { get; set; }

        public string Tipo { get; set; }
        public int Quantidade { get; set; }


        public Aquatico(int placa, string modelo, bool aluguel, string cor, string tipo, int quantidade) : base(placa, modelo, aluguel)
        {
            Modelo = modelo;
            Cor = cor;
            Tipo = tipo;
            Quantidade = quantidade;
        }

        public void AdcionarQuantidade(int quantidade)
        {
            Quantidade += quantidade;
        }


    }
}
