using System;

namespace ejercicio09
{
    class Program
    {


        static void Main(string[] args)
        {
            int escalones;
            int escalonesHechos = 0;
            string asteriscos = "";

            Console.Title = "Ejercicio 9";
            Console.Write("Ingrese tamanio de piramide: ");
            escalones = int.Parse(Console.ReadLine());

            if (escalones > 0)
            {

                for (int i = 1; escalonesHechos < escalones; i++)
                {
                    if (i == 1)
                    {
                        asteriscos += "*";
                        Console.WriteLine(asteriscos);
                        escalonesHechos++;
                        continue;
                    }
                    asteriscos += "**";
                    Console.WriteLine(asteriscos);
                    escalonesHechos++;
                }
            }
            Console.ReadLine();
        }
    }
}
