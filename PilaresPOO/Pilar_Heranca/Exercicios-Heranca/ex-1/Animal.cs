using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Pilar_Heranca.Exercicios_Heranca.ex_1
{
    internal class Animal
    {
        public string Nome { get; set; }

        public void Comer()
        {
            Console.WriteLine($"{Nome} esta comendo!");
        }
    }
}
