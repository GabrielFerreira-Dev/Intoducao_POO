using System;
using System.Globalization;
using Exercicios_01;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            System.Console.WriteLine("Entre a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.WriteLine();
            System.Console.WriteLine("ÁREA: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine($"PERÍMETRO: {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"DIAGONAL: {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();

        }
    }
}