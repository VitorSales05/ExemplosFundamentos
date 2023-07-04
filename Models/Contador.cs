using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Contador
    {
        public void Multiplicador()
        {
            Console.WriteLine("Digite o número base:");
            int numeroBase = Convert.ToInt32(Console.ReadLine());

            // FOR
            for(int multi = 0; multi <= 10; multi++)
            {
                Console.WriteLine($"{numeroBase} x {multi} = {numeroBase * multi}");
            }

            // WHILE
            int contador = 0;
            while(contador <= 10) {
                Console.WriteLine($"{contador + 1}° Execução: {numeroBase} x {contador} = {numeroBase * contador}");
                contador++;
            }
        }


        public void LoopingDeSoma()
        {
            int soma = 0;
            int numero = 0;

            do
            {
                Console.Write("Digite um número para somar (0 pausa): ");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            } while(numero != 0);

            Console.WriteLine($"Total da soma: {soma}");
        }
    }
}