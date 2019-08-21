using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_02
{
    public class MiClase
    {
        public static string nombre;
        public static int edad;
        public static void MostrarEdad()
        {
            Console.WriteLine("La edad es {0}",MiClase.edad);
            Console.ReadLine();
        }
        public static string RetornarNombre()
        {
            return MiClase.nombre;
        }
        
        public static bool CompararNombres(string nombre)
        {
            bool r = false;
            if(nombre == MiClase.nombre)
            {
                r = true;
            }
            return r;
        }
    }
}
