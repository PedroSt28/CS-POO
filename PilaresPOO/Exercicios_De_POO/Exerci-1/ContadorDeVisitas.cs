using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios_De_POO.Exerci_1
{
    internal class ContadorDeVisitas
    {
        private int Visitas { get; set; } //deixa inalteravel pelo codigo ou seja so da para mudar se passar pelos metodos

            public void RegistrarVisita()
              {
            //Visitas + 1
                Visitas++;
              }

        public int ObterTotal()
        {
            return Visitas;
        }
    }
}
