using Billetes;
using System;
namespace ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar d = new Dolar(100, 1);
            Pesos p = new Pesos(1000,60);
            Euro e = new Euro(100,(float)0.91);

            Console.WriteLine("Calculos con el dolar\n");
            Console.WriteLine("Dolar(100) mas pesos(1000): {0}", (d + p).cantidad);
            Console.WriteLine("Dolar(100) mas Euros(100): {0}", (d + e).cantidad);
            Console.WriteLine("Dolar(100) mas dolares(100)(pesos casteados): {0}", (d + (Pesos)d).cantidad);
            Console.WriteLine("Dolar(100) == Euro(100)(true)?: {0}", (d == e));
            Console.WriteLine("Dolar(100) == Peso(1000)(false)?: {0}", (d == p));
            Console.WriteLine("Euro(100) == peso(1000)(true)?: {0}", (e != p));
            Console.WriteLine("Euro(100) == Dolar(100)(false)?: {0}", (e != d));
            Console.Read();

        }
    }
}
