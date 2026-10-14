using System;
using System.Collections.Generic;
using System.Text;

namespace Praaticas_De_Exercicio
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine($"\nOla meu nome é {nome}, e eu tenho {idade} anos! Muito prazer\n");
        }
    }
}
