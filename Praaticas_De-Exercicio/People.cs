using System;
using System.Collections.Generic;
using System.Text;

namespace Praaticas_De_Exercicio
{
    public class People
    {
        public string Nome;
        

        public void Cumprimentar()
        {
            Console.WriteLine($"Ola,eu sou o/a {Nome}");
        }

        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Ola {outraPessoa}, eu sou o {Nome}");
        }

        public string ObterApresentação()
        {
            string apresentacao = $"Ola Meu nome é {Nome}";
            return apresentacao;
        }

    }
}
