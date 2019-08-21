using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MiLibreria;

namespace clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
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
            if(sameName==true)
            {
                Console.WriteLine("El nombre ingrsado es igual al definido en la clase");
            }
            else
            {
                Console.WriteLine("El nombre ingrsado NO es igual al definido en la clase");
            }



            Console.ReadLine();

        }
    }
}
