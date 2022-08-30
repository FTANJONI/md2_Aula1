using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1.Model
{
    class Aluno
    {
        //Caracteristicas de uma classe (atributos)
        public string nome;
        public int idade;
        
        public void imprimiNome()
        {
            Console.WriteLine(nome + " Idade " + idade);
        }
        //Operações ou funcionalidades (Métodos)
    }
}
