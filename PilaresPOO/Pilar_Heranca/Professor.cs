using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Pilar_Heranca
{
    internal class Professor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

         public void Apresentar()
        {
            Console.WriteLine($"ola meu nome é {Nome}, e eu tenho {Idade}");
        }
    }
}
