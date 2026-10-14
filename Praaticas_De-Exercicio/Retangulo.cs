using System;
using System.Collections.Generic;
using System.Text;

namespace Praaticas_De_Exercicio
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            double area = Largura * Altura; 
            return area;
        }

        public double CalcularPerimetro() 
        {
            double perimetro = (Largura * 2) + (Altura * 2);
            return perimetro;   
        }

        
        
      
    }
}
