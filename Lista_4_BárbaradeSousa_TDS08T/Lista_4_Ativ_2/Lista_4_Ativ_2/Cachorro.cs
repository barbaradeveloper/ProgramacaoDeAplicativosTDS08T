using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_2
{
    class Cachorro: Animal
    {
        public string Late { get; set; }

        public Cachorro(string nome, string raca, string late) : base(nome, raca)
        {
            Late = late;
        }
    }
}
