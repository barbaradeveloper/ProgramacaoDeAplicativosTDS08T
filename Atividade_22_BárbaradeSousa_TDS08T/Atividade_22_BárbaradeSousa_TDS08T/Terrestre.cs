using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_22_BárbaradeSousa_TDS08T
{
    class Terrestre: Veiculo
    {
      
        public string Cor { get; set; }

        public string Tipo { get; set; }
        public int Quantidade { get; set; }


        public Terrestre(int placa, string modelo, bool aluguel, string cor, string tipo, int quantidade) : base(placa, modelo, aluguel)
        {
            Cor = cor;
            Modelo = modelo;
            Tipo = tipo;
            Quantidade = quantidade;
        }

        public void MudarCor(string cor)
        {
            Cor = cor;
        }
    }
}
