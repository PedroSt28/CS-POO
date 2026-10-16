using PilaresPOO;
using PilaresPOO.Exercicios_De_POO.Exerci_1;
using PilaresPOO.Exercicios_De_POO.Exerci_2;
using PilaresPOO.Pilar_Heranca;
using PilaresPOO.Pilar_Heranca.Exercicios_Heranca.ex_1;
using PilaresPOO.Pilar_Heranca.Exercicios_Heranca.ex_2;
using PilaresPOO.Pilar_Heranca.Exercicios_Heranca.Ex_3;



//Metodo Construtor - Obriga um objeto a ser criado de uma forma
//Pilares POO


//Evitar Estados Invalidos

//adicionar da aula extra!!!!!!!!!!!!!!!!!!!!!!!





//Exercicios de Encapsulamento 
// GET -> Função de Ler
// SET -> Função de Mudar 
Console.WriteLine("------------Exercicio 1-------------");
ContadorDeVisitas contador = new ContadorDeVisitas();

contador.RegistrarVisita();
contador.RegistrarVisita();
contador.RegistrarVisita();

Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");



Console.WriteLine("------------Exercicio 2-------------");
Boletim boletim = new Boletim();
boletim.Aluno = "Ana";

boletim.DefinirNota(8.5);
boletim.DefinirNota(15);

Console.WriteLine($"{boletim.Aluno}: nota {boletim.ObterNota()}");



// Aprendendo Herança

Aluno aluno = new Aluno();

aluno.Idade = 20;
aluno.Nome = "Pedro";

aluno.Apresentar();


//----------Exercicios de herança

Console.WriteLine("\n\n\n\n\n------------Exercicio de Herança 1-------------");

Cachorro cachorro = new Cachorro();
cachorro.Nome = "Rex";

cachorro.Comer();
cachorro.Latir();




Console.WriteLine("\n\n\n\n\n------------Exercicio de Herança 2-------------");

Funcionario ana = new Funcionario("Ana", 3000);
Gerente carlos = new Gerente("Carlos", 5000, 1500);

Console.WriteLine($"{ana.Nome}: R$ {ana.Salario:F2}");
Console.WriteLine($"{carlos.Nome}: R$ {carlos.Salario:F2} + bônus = R$ {carlos.SalarioComBonus():F2}");




Console.WriteLine("\n\n\n\n\n------------Exercicio de Herança 3-------------");


Carro carro = new Carro("Fiat", "Uno", 4);
Moto moto = new Moto("Honda", "CG 160", 160);

carro.Exibir();
carro.ExibirPortas();

moto.Exibir();
moto.ExibirCilindradas();