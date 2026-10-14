// objeto é uma variavel

//TIPO E NOME

using POOFundamentos;

//instanciar
Carro carroPedro = new Carro();

carroPedro.Modelo = "Corsinha";
carroPedro.Marca = "sla vei";
carroPedro.Ano = 2013;

carroPedro.ExibirInformacoes();  

//instanciar novo objeto

Carro car1 = new Carro();
car1.Modelo = "Celta";
car1.Marca = "play";
car1.Ano = 1978;

car1.ExibirInformacoes();





//Criar uma clase pedido 
// Nome do cliente, Item, Quantidade, preço

Pedido pedido1 = new Pedido(); //criado

Console.WriteLine("me diga seu nome:");
pedido1.Nome = Console.ReadLine(); // colocando o valor digitado dentro do nome que esta no pedido

Console.WriteLine("me diga seu Item: ");
pedido1.Item = Console.ReadLine();


Console.WriteLine("me diga a quantidade :");
pedido1.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("me diga o preço :");
pedido1.Preco = double.Parse(Console.ReadLine());

pedido1.ExibirPedido();// chama o metodo para mostrar 

// ouuuuu (voce cham um por um como se fosse uma variavel

//Console.WriteLine(pedido1.Nome)
