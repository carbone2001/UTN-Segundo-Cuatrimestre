using LibreriaEjercicios;
using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            char continuar;
            Console.Title = "Ejercicio 11";
            do
            {
                //Console.Clear;
                Console.Write("Ingrese un numero entre 100 y -100: ");
                input = int.Parse(Console.ReadLine());
                if (Validacion.Validar(input, -100, 100))
                {
                    Console.WriteLine("Perfecto!");
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
                Console.Write("Desea seguir intentando? s/n");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's');

        }
    }
}
