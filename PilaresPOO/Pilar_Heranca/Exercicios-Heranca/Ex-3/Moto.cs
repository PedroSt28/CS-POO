using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Pilar_Heranca.Exercicios_Heranca.Ex_3
{
    internal class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string marca, string modelo, int cilindradas) : base(marca, modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindradas = cilindradas;
        }

        public void ExibirCilindradas()
        {
             Console.WriteLine($"Cilindradas: {Cilindradas}");
        }
    }
}
