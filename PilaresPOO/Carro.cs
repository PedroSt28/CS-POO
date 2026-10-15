using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    public class Carro
    {
        public string Marca;
        public string Modelo;

        //Metodo Construtor
        // Nao tem tipo de retorno
        // Ele tem o mesmo nome da classe

        public Carro(string marca, string modelo) 
        {
            Marca = marca; 
            Modelo = modelo;
        }
    }
}
