using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno();
            Alumno a2 = new Alumno();
            Alumno a3 = new Alumno();

            byte nota1;
            byte nota2;

            Console.WriteLine("Alumno 1");
            Console.Write("Ingrese nombre: ");
            a1.nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            a1.apellido = Console.ReadLine();
            Console.Write("Ingrese legajo: ");
            a1.legajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese primera nota: ");
            nota1 = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese segunda nota: ");
            nota2 = byte.Parse(Console.ReadLine());
            a1.Estudiar(nota1, nota2);
            a1.CalcularFinal();

            Console.WriteLine("Alumno 2");
            Console.Write("Ingrese nombre: ");
            a2.nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            a2.apellido = Console.ReadLine();
            Console.Write("Ingrese legajo: ");
            a2.legajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese primera nota: ");
            nota1 = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese segunda nota: ");
            nota2 = byte.Parse(Console.ReadLine());
            a2.Estudiar(nota1, nota2);
            a2.CalcularFinal();


            Console.WriteLine("Alumno 3");
            Console.Write("Ingrese nombre: ");
            a3.nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            a3.apellido = Console.ReadLine();
            Console.Write("Ingrese legajo: ");
            a3.legajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese primera nota: ");
            nota1 = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese segunda nota: ");
            nota2 = byte.Parse(Console.ReadLine());
            a3.Estudiar(nota1, nota2);
            a3.CalcularFinal();

            Console.WriteLine("\nNota final de A1: " + a1.Mostrar());
            Console.WriteLine("Nota final de A2: " + a2.Mostrar());
            Console.WriteLine("Nota final de A3: " + a3.Mostrar());
            Console.ReadLine();


        }
    }
}
