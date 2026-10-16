using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Pilar_Heranca.Exercicios_Heranca.ex_2
{
    internal class Gerente : Funcionario
    {

        public double Bonus { get; set; }

        public Gerente(string nome, double salario, double bonus) : base(nome, salario)
        {
            Nome = nome;
            Salario = salario;
            Bonus = bonus;
        }

        public double SalarioComBonus()
        {
            Salario = Salario + Bonus;
            return Salario;
        }
    }
}
