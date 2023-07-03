using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Contador
    {
        public void Multiplicador(int multiplicado)
        {
            // FOR
            for(int multi = 0; multi <= 10; multi++)
            {
                Console.WriteLine($"{multiplicado} x {multi} = {multiplicado * multi}");
            }

            // WHILE
            int contador = 0;
            while(contador <= 10) {
                Console.WriteLine($"{contador + 1}° Execução: {multiplicado} x {contador} = {multiplicado * contador}");
                contador++;
            }
        }
    }
}