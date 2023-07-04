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
            for(int multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine($"{numeroBase} x {multiplicador} = {numeroBase * multiplicador}");
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