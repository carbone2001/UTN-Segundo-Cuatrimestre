using System;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            Boligrafo bolAzul = new Boligrafo(50, ConsoleColor.Blue);
            Boligrafo bolRojo = new Boligrafo(5, ConsoleColor.Red);
            string dibujo;


            if (bolAzul.Pintar(51, out dibujo) == false)
            {
                Console.WriteLine("\n Tinta insuficiente");
            }
            Console.WriteLine(dibujo);


            if (bolRojo.Pintar(5, out dibujo) == false)
            {
                Console.WriteLine("\nTinta insuficiente");
            }
            Console.WriteLine(dibujo);
            Console.ReadLine();


        }
    }
}
