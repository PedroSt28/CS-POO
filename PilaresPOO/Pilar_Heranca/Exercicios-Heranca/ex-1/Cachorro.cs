using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Pilar_Heranca.Exercicios_Heranca.ex_1
{
    internal class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{Nome}: Au Au");
        }
    }
}
