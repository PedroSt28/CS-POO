using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PilaresPOO.Exercicios_De_POO.Exerci_2
{
    internal class Boletim
    {
        public string Aluno { get; set; }
        private double Nota;

        public void DefinirNota(double valor)
        {
            if(valor >= 0 && valor  <= 10)
            {
                Nota = valor;
            }
            else
            {
                Console.WriteLine($"Nota Invalida : {valor}");
            }

        }

        public double ObterNota()
        {
            return Nota;
        }
    }
}
