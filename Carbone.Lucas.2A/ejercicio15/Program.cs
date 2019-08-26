using LibreriaEjercicios;
using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            char signo;
            char opcion;
            Console.Title = "Ejercicio 15";
            do
            {
                Console.Write("Ingrese el primer numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el signo para la operacion(+,-,*,/): ");
                signo = char.Parse(Console.ReadLine());
                Console.WriteLine("Resultado: {0}", Calculadora.Calcular(numero1, numero2, signo));

                Console.Write("Desea seguir haciendo cuentas?(s/n): ");
                opcion = char.Parse(Console.ReadLine());
            } while (opcion == 's');


        }
    }
}
