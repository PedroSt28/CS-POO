using Praaticas_De_Exercicio;

//Console.WriteLine("----------------- Exercicio 1 ----------------");

//Pessoa p1  = new Pessoa();

//Console.WriteLine("Qual é o seu nome?: ");
//p1.nome = Console.ReadLine();

//Console.WriteLine("Quantos anos voce tem?");
//p1.idade = int.Parse(Console.ReadLine());
//p1.Apresentar();


//Pessoa p2 = new Pessoa();
//Console.WriteLine("Qual é o seu nome?: ");
//p2.nome  = Console.ReadLine();

//Console.WriteLine("Quantos naos voce tem?: ");
//p2.idade = int.Parse(Console.ReadLine());

//p2.Apresentar();






//Console.WriteLine("----------------- Exercicio 2 ----------------");


//Retangulo Retangulo1 = new Retangulo();

//Console.WriteLine("Qual a Largura do retangulo: ");
//Retangulo1.Largura = double.Parse(Console.ReadLine());

//Console.WriteLine("Qual a Altura do retangulo: ");
//Retangulo1.Altura = double.Parse(Console.ReadLine());

//Console.WriteLine($"Area:{Retangulo1.CalcularArea()}\nPerimetro:{Retangulo1.CalcularPerimetro()}");






//Console.WriteLine("----------------- Exercicio 3 ----------------");

//Lampada Lampada1 = new Lampada();
//Lampada1.ligada = true;

//Console.WriteLine(Lampada1.ExibirEstado());
//Console.WriteLine(Lampada1.Alternar);





//---------------------------------------Lista 2


Console.WriteLine("----------------- Exercicio 1_ Lista 2 ----------------"); //Lista 2 


People Peo1 = new People();

Peo1.Nome = "Ana";

Peo1.Cumprimentar();
Peo1.CumprimentarAlguem("Bruno");

string frase = Peo1.ObterApresentação();
Console.WriteLine(frase);








    Console.WriteLine("----------------- Exercicio 2 _ Lista 2 ----------------"); //Lista 2 

Calculadora cal1 = new Calculadora();

int soma = cal1.Somar(10, 5);
cal1.MostrarResultado(soma);
cal1.MostrarResultado(cal1.Subtrair(10,5));



Console.WriteLine("----------------- Exercicio 3 _ Lista 2 ----------------");

Conversor conv = new Conversor();

double f = conv.CelsiusParaFarenhigth(25);
Console.WriteLine($"25°C = {f}°F");

if (conv.EstaQuente(35))
{
    Console.WriteLine("35°C: está quente!");
}

if (!conv.EstaQuente(18))
{
    Console.WriteLine("18°C: não está quente.");
}










Console.WriteLine("----------------- Exercicio 4 _ Lista 2 ----------------");





Cofrinho cofre = new Cofrinho();

cofre.Guardar(50);
cofre.Guardar(-10);
cofre.Guardar(30);

if (cofre.RetirarValoe(100))
    Console.WriteLine("Retirada feita!");
else
    Console.WriteLine("Saldo insuficiente.");

if (cofre.RetirarValoe(20))
    Console.WriteLine("Retirada feita!");
else
    Console.WriteLine("Saldo insuficiente.");

Console.WriteLine($"Saldo: R$ {cofre.Saldo:F2}");
Console.WriteLine($"Faltam R$ {cofre.FaltaParaMeta(200):F2} para a meta.");












