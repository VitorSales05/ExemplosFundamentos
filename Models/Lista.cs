using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Lista
    {
        public void ArrayNumeros()
        {
            int[] arrayInteiros = new int[4];

            arrayInteiros[0] = 15;
            arrayInteiros[1] = 26;
            arrayInteiros[2] = 48;
            arrayInteiros[3] = 75;


            Console.WriteLine("Percorrendo o Array com o FOR");
            for(int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Posição no Array {contador} - {arrayInteiros[contador]}");
            }

            Console.WriteLine("Percorrendo o Array com o FOREACH");
            int contadorForEach = 0;
            foreach(int valor in arrayInteiros)
            {
                Console.WriteLine($"Posição no Array {contadorForEach} - {valor}");
                contadorForEach++;
            }
        }
    }
}