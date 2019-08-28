using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            Boligrafo bolAzul = new Boligrafo(50,ConsoleColor.Blue);
            Boligrafo bolRojo = new Boligrafo(5,ConsoleColor.Red);
            string dibujo;


            if (bolAzul.Pintar(20, out dibujo) == false)
            {
                Console.WriteLine("\n Tinta insuficiente");
            }
            Console.ForegroundColor = bolAzul.GetColor();
            Console.WriteLine(dibujo);

            if (bolRojo.Pintar(20, out dibujo) == false)
            {
                Console.WriteLine("\n Tinta insuficiente");
            }
            Console.ForegroundColor = bolRojo.GetColor();
            Console.WriteLine(dibujo);
            Console.ReadLine();


        }
    }
}
