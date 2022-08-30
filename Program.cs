using System;
using Aula_1.Model; //caminho da pasta model(Insira os pacotes da pasta Model, ou seja, da classe criada)

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {//instanciar um objeto:criando o objeto | Passa a existir fisicamente
            //Classe(Aluno) nomeObjeto(alu) = new construtor | new (operador de instanciação)
            Aluno alu = new Aluno();
            alu.nome = "Gaspar";
            alu.idade = 2;

            Aluno alu2 = new Aluno();
            alu2.nome = "Uriel";
            alu2.idade = 6;

            Aluno alu3 = new Aluno();
            alu3.nome = "Sarah";
            alu3.idade = 3;
            alu.imprimiNome();
            alu2.imprimiNome();
            alu3.imprimiNome();
        }
    }
}
