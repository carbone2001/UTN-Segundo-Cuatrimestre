using Clase05.Entidades;
using System;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Pluma p1 = new Pluma();
            Pluma p2 = new Pluma();
            Pluma p3 = new Pluma();
            Tinta t1 = new Tinta();
            Tinta t2 = new Tinta(ConsoleColor.Yellow);
            Tinta t3 = new Tinta(ConsoleColor.Black, ETipoTinta.China);
            t1 = null;

            p1 = null;
            if (t1 != t2)
                Console.WriteLine("Ambos son diferentes");
            if (p1 == t1)
                Console.WriteLine("Ambos son null");
            if (p1 != p2)
                Console.WriteLine("Son distintos");
            if (t2 != t3)
                Console.WriteLine("Son diferentes");
            Console.WriteLine("Prueba de casteo. " + (string)t3);
            Console.Read();
        }
    }
}
