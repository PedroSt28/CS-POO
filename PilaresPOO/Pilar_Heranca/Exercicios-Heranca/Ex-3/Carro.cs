using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Pilar_Heranca.Exercicios_Heranca.Ex_3
{
    internal class Carro : Veiculo
    {
        public int Portas { get; set; }

        public Carro(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Marca = marca;
            Modelo =modelo;
            Portas = portas;
        }

        public void ExibirPortas()
        {
            Console.WriteLine($"Portas: {Portas}");
        }
    }
}
