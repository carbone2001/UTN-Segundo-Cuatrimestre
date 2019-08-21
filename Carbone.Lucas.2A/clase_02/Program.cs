using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiLibreria;
using Clase_02.Entidades;

namespace clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string nombre;
            string nombre2;
            bool sameName;
            MiClase.edad = 23;
            MiClase.nombre = "Juan";
            MiClase.MostrarEdad();
            nombre = MiClase.RetornarNombre();
            Console.WriteLine(nombre);

            Console.Write("Ingrese nombre:");
            nombre2 = Console.ReadLine();
            sameName = MiClase.CompararNombres(nombre2);
            if (sameName == true)
            {
                Console.WriteLine("El nombre ingrsado es igual al definido en la clase");
            }
            else
            {
                Console.WriteLine("El nombre ingrsado NO es igual al definido en la clase");
            }



            Console.ReadLine();*/
            ConsoleColor color;
            string msj;

            
            Sello.mensaje = "Hola mundo";
            msj = (Sello.Imprimir());
            Sello.Borrar();
            msj = (Sello.Imprimir());


            Sello.mensaje = "Hola";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();


            Console.Write("Ingrese numero para cambiar color: ");
            color = (ConsoleColor)(int.Parse(Console.ReadLine()));
            Sello.color = color;
            Sello.ImprimirEnColor();




            Console.ReadLine();
        }
    }
}
