using System;
using System.Globalization;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.Conversao(valor, cotacao);
            Console.WriteLine();
            Console.WriteLine("Valor a pagar: $" + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

           
        }
    }
}
