using System;
using System.Globalization;

namespace Exercicio9
{
    internal class ConversorDeMoeda
    {
       public static double Iof = 0.6;
        public static double Conversao(double valor, double cotacao)
        {
            return valor * cotacao + valor * Iof;
        }  
        
    }
}
