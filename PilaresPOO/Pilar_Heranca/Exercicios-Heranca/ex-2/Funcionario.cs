using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Pilar_Heranca.Exercicios_Heranca.ex_2
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

       public Funcionario(string nome, double salario)
        {
            Nome = nome; 
            Salario = salario;
        }
    }

}
