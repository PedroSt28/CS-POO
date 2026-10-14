using System;
using System.Collections.Generic;
using System.Text;

namespace POOFundamentos
{
    //Classe - Molde
    internal class Pedido
    {

        //Atributos - caracteristicas
        //nome, item,quantidade,preço
        public string Nome;
        public string Item;
        public int Quantidade;
        public double Preco;


        //Metodos- Ações
        public void ExibirPedido()
        {
            Console.WriteLine($"\n \n \n Olá {Nome}, Conferindo seu pedido!");
            Console.WriteLine($"Produto: {Item}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Preço: {Preco}");
        }
    }
}
