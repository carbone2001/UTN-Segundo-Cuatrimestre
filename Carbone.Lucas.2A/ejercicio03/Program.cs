using System;

namespace ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int contador;
            Console.Title = "Ejercicio 3";
            Console.Write("Ingrese un numero: ");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {

                for (int i = 1; i <= number; i++)
                {
                    contador = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            contador++;
                        }
                    }
                    if (contador == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nEl numero ingresado no puede ser 0 ni negativo!\n");
            }
            Console.ReadLine();
        }
    }
}
