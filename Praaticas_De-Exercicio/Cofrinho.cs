using System;
using System.Collections.Generic;
using System.Text;

namespace Praaticas_De_Exercicio
{
    public class Cofrinho
    {
        public String Dono;
        public double Saldo = 0;
        public void Guardar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor Invalido");
            }
            else
            {
                Console.WriteLine($"Guardou R${Saldo + valor}");
            }
        }

        public bool RetirarValoe(double valor)
        {
            if (valor > 0)
            {
                double novoSaldo = Saldo - valor;
                return true ;
            }
            return false ;
        }

        public double FaltaParaMeta(double meta)
        {
            if(meta == Saldo)
            {
                return 0;
            }
            double restoMeta = meta - Saldo;
            return restoMeta;
        }
    }
}
