using System;

namespace ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int resultadoCuadrado;
            int resultadoCubo;
            Console.Title = "Ejercicio 2";
            Console.WriteLine("Ingrese un numero: ");
            number = int.Parse(Console.ReadLine());
            while (number == 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                number = int.Parse(Console.ReadLine());
            }
            resultadoCuadrado = (int)Math.Pow(number, 2);
            resultadoCubo = (int)Math.Pow(number, 3);

            Console.WriteLine("Resultado Ingresado: {0}\nResultado al Cuadrado: {1}\nResultado al Cubo: {2}", number, resultadoCuadrado, resultadoCubo);
            Console.ReadLine();
        }
    }
}
