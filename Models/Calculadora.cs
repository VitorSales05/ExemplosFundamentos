using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar()
        {
            Console.WriteLine("-- Somar --");
            Console.WriteLine("Digite um número:");
            int varSoma1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            int varSoma2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            Console.WriteLine($"{varSoma1} + {varSoma2} = {varSoma1 + varSoma2}");
        }

        public void Subtrair()
        {
            Console.WriteLine("-- Subtrair --");
            Console.WriteLine("Digite um número:");
            int varSubtrair1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            int varSubtrair2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            Console.WriteLine($"{varSubtrair1} - {varSubtrair2} = {varSubtrair1 - varSubtrair2}");
        }

        public void Dividir()
        {
            Console.WriteLine("-- Dividir --");
            Console.WriteLine("Digite um número:");
            int varDividir1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            int varDividir2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            Console.WriteLine($"{varDividir1} / {varDividir2} = {varDividir1 / varDividir2}");
        }

        public void Multiplicar()
        {
            Console.WriteLine("-- Multiplicar --");
            Console.WriteLine("Digite um número:");
            int varMultiplicar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            int varMultiplicar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            Console.WriteLine($"{varMultiplicar1} * {varMultiplicar2} = {varMultiplicar1 * varMultiplicar2}");
        }

        public void Potencia()
        {
            Console.WriteLine("-- Potência --");
            Console.WriteLine("Digite um número:");
            int varPotencia1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a potência:");
            int varPotencia2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            double potencia = Math.Pow(varPotencia1, varPotencia2);
            Console.WriteLine($"{varPotencia1}^{varPotencia2} = {potencia}");
        }

        public void Seno()
        {
            Console.WriteLine("-- Seno --");
            Console.WriteLine("Digite o angulo:");
            int angulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {seno}");
        }

        public void Coseno()
        {
            Console.WriteLine("-- Coseno --");
            Console.WriteLine("Digite o angulo:");
            int angulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {cosseno}");
        }

        public void Tangente()
        {
            Console.WriteLine("-- Tangente --");
            Console.WriteLine("Digite o angulo:");
            int angulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {tangente}");
        }

        public void RaizQuadrada()
        {
            Console.WriteLine("-- Raiz Quadrada --");
            Console.WriteLine("Digite um número:");
            int variavel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("** Resultado **");
            double raiz = Math.Sqrt(variavel);
            Console.WriteLine($"Raiz quadrada de {variavel} = {raiz}");
        }
    }
}