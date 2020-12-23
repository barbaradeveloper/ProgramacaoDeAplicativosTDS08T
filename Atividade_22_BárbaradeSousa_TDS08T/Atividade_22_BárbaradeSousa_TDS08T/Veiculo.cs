using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_22_BárbaradeSousa_TDS08T
{
    class Veiculo
    {
        public int Placa { get; set; }

        public string Modelo { get; set; }

        public bool Aluguel { get; set; }

        public Veiculo(int placa, string modelo, bool aluguel)
        {
            Placa = placa;
            Modelo = modelo;
            Aluguel = aluguel;
        }

        public void MudarModelo(string modelo)
        {
            Modelo = modelo;
        }

    }
}
