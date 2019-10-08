using System;
using LibreriaEjercicios;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            double input2;
            Console.Title = "Ejercicio 14";

            Console.Write("\nIngrese lado de un cuadrado: ");
            input = double.Parse(Console.ReadLine());
            Console.WriteLine("El area del cuadrado es: {0}", CalculoDeArea.CalcularCuadrado(input));

            Console.Write("\nIngrese base de un triangulo: ");
            input = double.Parse(Console.ReadLine());
            Console.Write("\nIngrese altura de un triangulo: ");
            input2 = double.Parse(Console.ReadLine());
            Console.WriteLine("El area del triangulo es: {0}", CalculoDeArea.CalcularTriangulo(input, input2));

            Console.Write("\nIngrese radio de un circulo: ");
            input = double.Parse(Console.ReadLine());
            Console.WriteLine("El area del circulo es: {0}", CalculoDeArea.CalcularCirculo(input));
            Console.ReadLine();

        }
    }
}
