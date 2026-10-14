
//------------------------Glossario de Programação orientada em objetos -------------------


// Classes -- Molde (Definir oque é um carro?) Explica oque é uma coisa 
//Objeto -- Instancia de uma classe (instanciar Coisas que ja existem ) Materialização de uma classe

//Atributos - Caracteristicas ( Cor do carro , Modelo , Ano ...)
//Metodos - Ações (Acelerar , Frear)

//1 . Formato:

//public class NOME_DA_CLASSE { }

//2 . Definir atributos
// public TIPO NOME

//3 . Definir Metodos
//Public RETORNO(da função) NOME() { }


using System;
using System.Collections.Generic;
using System.Text;

namespace POOFundamentos
{
    public class Carro // nome da classe sempre começa com letra maiuscula
    {// Definição (nao necessariamente precisa ter os dois )
        //Atributos
        public string Marca; //Tambem começam com letra maiuscula
        public string Modelo;
        public int Ano;

        //Metodos
        //Mostrar informações do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }

    }
}
