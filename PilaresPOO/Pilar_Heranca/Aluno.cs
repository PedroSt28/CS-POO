using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Pilar_Heranca
{
    internal class Aluno : Professor // adicionando os : mais o nome da outra classe, a classe Aluno herdou tudo seja função declaraçoes etc do professor
        //classe filho (Aluno)
        //classe Pai (Profesor)
    {
        //só o aluno tem 
        //nome 
        //Idade
        //Matricula
        public string Matricula { get; set; }
    }
}
