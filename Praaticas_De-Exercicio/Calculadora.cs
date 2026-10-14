using System;
using System.Collections.Generic;
using System.Text;

namespace Praaticas_De_Exercicio
{
    public class Calculadora
    {
        public int Somar(int x, int y)
        {
            int soma = x + y;
            return soma;
        }

        public int Subtrair(int x, int y)
        {
           int subtracao = x - y;
            return subtracao;
        } 

        public void MostrarResultado(int valor)
        {
            Console.WriteLine($"Resultado: {valor}");
        }

    }
}
