using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public void Cadastro(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é {nome}, e tenho {idade} anos.");
        }
    }
}