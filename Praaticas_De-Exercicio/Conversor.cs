using System;
using System.Collections.Generic;
using System.Text;

namespace Praaticas_De_Exercicio
{
    public class Conversor
    {
        public double CelsiusParaFarenhigth(double Celcius)
        {
            return Celcius * 1.8 + 32;
        }

        public bool EstaQuente(double Celcius)
        {
            return Celcius >= 30;
        }
    }
}
