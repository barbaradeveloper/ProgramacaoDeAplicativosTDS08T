using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_2
{
    class Gato: Animal
    {
        public string Mia { get; set; }

        public Gato(string nome, string raca, string late, string mia) : base(nome, raca)
        {

            Mia = mia;
        }
    }
}
