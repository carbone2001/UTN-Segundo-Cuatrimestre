using System;

namespace ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYr;
            int finishYr;

            Console.Title = "Ejercicio 6";
            Console.WriteLine("Ingrese anio de inicio: ");
            startYr = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese anio de fin: ");
            finishYr = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAnios bisiestos: ");
            for (int i = startYr; i <= finishYr; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
