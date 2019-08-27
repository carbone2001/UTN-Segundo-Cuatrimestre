using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int dni;
            Persona p;
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese dni: ");
            dni = int.Parse(Console.ReadLine());
            p = new Persona(nombre, apellido, dni);



            Persona p2;
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese dni: ");
            dni = int.Parse(Console.ReadLine());
            p2 = new Persona(nombre, apellido, dni);

            Console.Write(p.Mostrar());
            Console.WriteLine(p2.Mostrar());
            Console.Read();






        }
    }
}
