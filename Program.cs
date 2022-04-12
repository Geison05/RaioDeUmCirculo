using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            double A, R, pi = 3.14159;

            //Entrada

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Processamento

            A = pi * R * R;

            //Saida

            Console.WriteLine("Area =" + A.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}